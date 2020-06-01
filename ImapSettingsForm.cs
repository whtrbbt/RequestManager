using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //ImapSettingsForm imapSettings = this;
            //imapSettings.Close();
        }
    }
}
