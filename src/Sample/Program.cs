namespace Sample;

static class Program
{
    public static AccountInfo? AccountInfo;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        AccountInfo = new() { Name = "Main Account" };

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}

public class AccountInfo
{
    public required string Name { get; init; }
    public decimal AccountValue { get; private set; } = decimal.Zero;

    public class AccountInfoUpdatedEventArgs : EventArgs
    {
        public required decimal PreviousAccountValue { get; init; }
        public required decimal Delta { get; init; }
        public required decimal CurrentAccountValue { get; init; }
    }

    public event EventHandler<AccountInfoUpdatedEventArgs>? AccountInfoUpdated;

    protected void OnAccountInfoUpdated(decimal accountValue)
    {
        if(AccountInfoUpdated == null) return;
        
        var previousAccountValue = AccountValue;
        AccountValue += accountValue;

        AccountInfoUpdated(this, new()
            { CurrentAccountValue = AccountValue, Delta = accountValue, PreviousAccountValue = previousAccountValue });

    }

    public void AddValue(decimal accountValue)
    {
        OnAccountInfoUpdated(accountValue);
    }
}