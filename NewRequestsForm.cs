using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RequestManager
{
    public partial class NewRequestsForm : Form
    {
        public NewRequestsForm()
        {
                    
            InitializeComponent();
            ImapClient imapClient = this.CreateIMAPConnection();
            if (imapClient.IsConnected)
            {
                iMAPServerStatusLabel.Text = "OK";
                iMAPServerStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                iMAPServerStatusLabel.Text = "X";
                iMAPServerStatusLabel.ForeColor = Color.Red;
            }
            if (imapClient.IsAuthenticated)
            {
                IMAPServerAuthStatusLabel.Text = "OK";
                IMAPServerAuthStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                IMAPServerAuthStatusLabel.Text = "X";
                IMAPServerAuthStatusLabel.ForeColor = Color.Red;
            }

            try
            {
                var folder = imapClient.GetFolder(Properties.Settings.Default.FOLDER);
                if (folder.Exists)
                {
                    IMAPFolderStatusLabel.Text = "OK";
                    IMAPFolderStatusLabel.ForeColor = Color.Green;
                    IList<UniqueId> messagesUids = GetNewRequests(folder);
                    if (messagesUids.Count() >= 0)
                        NewRequestsCountLabel.Text = messagesUids.Count().ToString();
                    else
                        NewRequestsCountLabel.Text = "Н/Д";
                }
                else
                {
                    IMAPFolderStatusLabel.Text = "X";
                    IMAPFolderStatusLabel.ForeColor = Color.Red;
                    NewRequestsCountLabel.Text = "Н/Д";
                }
            }
            catch (Exception e)
            {
                IMAPFolderStatusLabel.Text = "X";
                IMAPFolderStatusLabel.ForeColor = Color.Red;
                NewRequestsCountLabel.Text = "Н/Д";
            }

           

        }

        private void NewRequestsForm_Load(object sender, EventArgs e)
        {

        }

        private ImapClient CreateIMAPConnection()
        {
           var client = new ImapClient();
           try
           {
                client.Connect(Properties.Settings.Default.IMAP_SERVER, 993, SecureSocketOptions.SslOnConnect);
                client.Authenticate(Properties.Settings.Default.LOGIN, Properties.Settings.Default.PASSWORD);
           }
           catch (Exception e)
           { }   
           return client;            
           


        }

        private IList<UniqueId> GetNewRequests (IMailFolder folder)
        {
            IList <UniqueId> uids;
            SearchQuery query;
            query = SearchQuery.NotSeen.And(SearchQuery.SubjectContains("Портал Росреестра: заявление выполн"));
            try
            {
                folder.Open(FolderAccess.ReadOnly);
                uids = folder.Search(query);
          
            }
            catch (Exception e)
            {
                uids = null;
            }
            return uids;
        }

        private void NewRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }

   
}
