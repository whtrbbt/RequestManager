using System;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
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
    }

   
}
