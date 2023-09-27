namespace Sample
{
    public partial class Form2 : Form
    {
        private readonly AccountInfo _accountInfo;

        public Form2()
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

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _accountInfo.AccountInfoUpdated -= AccountInfoOnAccountInfoUpdated;
        }
    }
}
