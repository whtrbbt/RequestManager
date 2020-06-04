using System;
using System.Windows.Forms;

namespace RequestManager
{
    public partial class ImapSettingsForm : Form
    {
        public ImapSettingsForm()
        {
            InitializeComponent();
            this.iMAPServerAddresTextBox.Text = Properties.Settings.Default.IMAP_SERVER;
            this.iMAPServerLoginTextBox.Text = Properties.Settings.Default.LOGIN;
            this.iMAPServerPasswordTextBox.Text = Properties.Settings.Default.PASSWORD;
            this.iMAPWorkFolderTextBox.Text = Properties.Settings.Default.FOLDER;
            this.Activate();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (this.ValidateForm())
            {
                Properties.Settings.Default.IMAP_SERVER = this.iMAPServerAddresTextBox.Text;
                Properties.Settings.Default.LOGIN = this.iMAPServerLoginTextBox.Text;
                Properties.Settings.Default.PASSWORD = this.iMAPServerPasswordTextBox.Text;
                Properties.Settings.Default.FOLDER = this.iMAPWorkFolderTextBox.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
                MessageBox.Show("Необходимо заполнить все поля!", "Внимание!");
            //ImapSettingsForm imapSettings = this;
            //imapSettings.Close();
        }

        private bool ValidateForm ()
        {
            if ((this.iMAPServerAddresTextBox.Text.Length == 0) ||
                (this.iMAPServerLoginTextBox.Text.Length == 0) ||
                (this.iMAPServerPasswordTextBox.Text.Length == 0) ||
                (this.iMAPWorkFolderTextBox.Text.Length == 0))
            {
                return false;
            }
            else
                return true;

        }


    }
}
