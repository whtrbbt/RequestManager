using System;
using Microsoft.WindowsAPICodePack.Dialogs;
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
    public partial class MainForm : Form
    {
        string INDir = @Properties.Settings.Default.REQ_IN_DIR;
        string OUTDir = @Properties.Settings.Default.REQ_OUT_DIR;

        public MainForm()
        {
            InitializeComponent();
            inDirTextBox.Text = Properties.Settings.Default.REQ_IN_DIR;
            outDirTextBox.Text = Properties.Settings.Default.REQ_OUT_DIR;

            if (!(CheckIMAPSettings()))
            {
                
                ImapSettingsForm imapSettings = new ImapSettingsForm();
                imapSettings.ShowDialog();
            }
        }

        private void inDirSelectButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                INDir = dialog.FileName;
                inDirTextBox.Text = INDir;
                Properties.Settings.Default.REQ_IN_DIR = INDir;
                Properties.Settings.Default.Save();
            }
        }

        private void outDirSelectButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                OUTDir = dialog.FileName;
                outDirTextBox.Text = OUTDir;
                Properties.Settings.Default.REQ_OUT_DIR = OUTDir;
                Properties.Settings.Default.Save();
            }
        }

        private void IMAPServerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImapSettingsForm imapSettings = new ImapSettingsForm();                     
            imapSettings.ShowDialog();
            
        }

        private static bool CheckIMAPSettings ()
        {
            if ((Properties.Settings.Default.IMAP_SERVER.Length == 0)||
                (Properties.Settings.Default.LOGIN.Length == 0)||
                (Properties.Settings.Default.PASSWORD.Length == 0)||
                (Properties.Settings.Default.FOLDER.Length == 0))
            {
                return false;
            }
            else
            return true;
        }

        private void OpenNewRequestsFormButton_Click(object sender, EventArgs e)
        {
            NewRequestsForm requestsForm = new NewRequestsForm();
            requestsForm.ShowDialog();
        }

        private void DBServerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSSQLServerSettingsForm serverSettingsForm = new MSSQLServerSettingsForm();
            serverSettingsForm.ShowDialog();
        }

        private void UserManamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
