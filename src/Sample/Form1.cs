namespace Sample;

public partial class Form1 : Form
{
    private readonly AccountInfo _accountInfo;

    public Form1()
    {
        InitializeComponent();

        _accountInfo = Program.AccountInfo ?? throw new Exception();

        _accountInfo.AccountInfoUpdated += AccountInfoOnAccountInfoUpdated;

        AccountValueLabel.Text = $@"{_accountInfo.AccountValue:C}";
    }

    private void AccountInfoOnAccountInfoUpdated(object? sender, AccountInfo.AccountInfoUpdatedEventArgs e)
    {
        AccountValueLabel.Text = $@"{e.CurrentAccountValue:C}";
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (decimal.TryParse(AccountInfoText.Text, out decimal value))
        {
            _accountInfo.AddValue(value);
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        _accountInfo.AccountInfoUpdated -= AccountInfoOnAccountInfoUpdated;
    }

    private void LoadForm2Button_Click(object sender, EventArgs e)
    {
        Form2 form2 = new();
        form2.Show();
    }
}
