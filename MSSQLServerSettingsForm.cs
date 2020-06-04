using System;
using System.Windows.Forms;

namespace RequestManager
{
    public partial class MSSQLServerSettingsForm : Form
    {
        public MSSQLServerSettingsForm()
        {
            InitializeComponent();
            MSSQLServrAddressTextBox.Text = Properties.Settings.Default.MSSQL_SERVER;
            MSSQLUidTextBox.Text = Properties.Settings.Default.MSSQL_UID;
            MSSQLPasswordTextBox.Text = Properties.Settings.Default.MSSQL_PASSWORD;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                Properties.Settings.Default.MSSQL_SERVER = MSSQLServrAddressTextBox.Text;
                Properties.Settings.Default.MSSQL_UID = MSSQLUidTextBox.Text;
                Properties.Settings.Default.MSSQL_PASSWORD = MSSQLPasswordTextBox.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
                MessageBox.Show("Необходимо заполнить все поля!", "Внимание!");

        }

        private bool ValidateForm()
        {
            if ((this.MSSQLServrAddressTextBox.Text.Length == 0) ||
                (this.MSSQLUidTextBox.Text.Length == 0) ||
                (this.MSSQLPasswordTextBox.Text.Length == 0))
            {
                return false;
            }
            else
                return true;

        }
    }
}
