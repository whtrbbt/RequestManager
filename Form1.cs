using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;

namespace RequestManager
{
    public partial class MainForm : Form
    {
        string INDir = @Properties.Settings.Default.REQ_IN_DIR;
        string OUTDir = @Properties.Settings.Default.REQ_OUT_DIR;
        bool CLEAROutDir = Properties.Settings.Default.CLEAR_OUT_DIR;
        public MainForm()
        {
            InitializeComponent();
            inDirTextBox.Text = Properties.Settings.Default.REQ_IN_DIR;
            outDirTextBox.Text = Properties.Settings.Default.REQ_OUT_DIR;
            clearOutDirCheckBox.Checked = CLEAROutDir;

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

        private void LoadRequestsButton_Click(object sender, EventArgs e)
        {
            LoadRequestsToDB loadRequests = new LoadRequestsToDB();
            loadRequests.ShowDialog();
        }

        private void GetFinishedRequestsButton_Click(object sender, EventArgs e)
        {
            GetFinishedRequestsForm getFinishedRequests = new GetFinishedRequestsForm();
            getFinishedRequests.ShowDialog();
        }

        private void RunBatchModeButton_Click(object sender, EventArgs e)
        {
            ProcessReqFileFromInDirForm processReqFileFromInDir = new ProcessReqFileFromInDirForm();
            processReqFileFromInDir.Show();
            processReqFileFromInDir.CheckRequestFromDir(Properties.Settings.Default.REQ_IN_DIR, Properties.Settings.Default.REQ_OUT_DIR, clearOutDirCheckBox.Checked);
            MessageBox.Show("Готово!");
            processReqFileFromInDir.Close();
        }

        private void clearOutDirCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CLEAR_OUT_DIR = clearOutDirCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
