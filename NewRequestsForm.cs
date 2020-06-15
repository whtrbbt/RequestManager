using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVUtility;
using System.Data.SqlClient;

namespace RequestManager
{
    public partial class NewRequestsForm : Form
    {
        ImapClient imapClient;
        IMailFolder workFolder;
        SearchQuery searchQuery;
        public DataTable requestsResponse;

        public NewRequestsForm()
        {
            int numOfRequests;
            searchQuery = SearchQuery.NotSeen.And(SearchQuery.SubjectContains("Портал Росреестра: заявление выполн"));            

            InitializeComponent();
            imapClient = this.CreateIMAPConnection();
            if (imapClient.IsConnected)
            {
                iMAPServerStatusLabel.Text = "OK";
                iMAPServerStatusLabel.ForeColor = Color.Green;
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
            else
            {
                iMAPServerStatusLabel.Text = "X";
                iMAPServerStatusLabel.ForeColor = Color.Red;
                IMAPServerAuthStatusLabel.Text = "X";
                IMAPServerAuthStatusLabel.ForeColor = Color.Red;
            }
            

            try
            {
                workFolder = imapClient.GetFolder(Properties.Settings.Default.FOLDER);
                if (workFolder.Exists)
                {
                    IMAPFolderStatusLabel.Text = "OK";
                    IMAPFolderStatusLabel.ForeColor = Color.Green;
                    numOfRequests = CountMessagesInFolder(workFolder, searchQuery);
                    if ( numOfRequests >= 0)
                    {
                        NewRequestsCountLabel.Text = numOfRequests.ToString();
                        DownloadRequestsDataButton.Enabled = true;
                    }

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

        private int CountMessagesInFolder (IMailFolder folder, SearchQuery query)
        {
            int numberOfMessages;           
            try
            {
                folder.Open(FolderAccess.ReadOnly);
                var uids = folder.Search(query);
                numberOfMessages = uids.Count();                          
            }
            catch (Exception e)
            {
                numberOfMessages = -1;
            }
            return numberOfMessages;
        }

        private void NewRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            imapClient.Disconnect(true);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void СancelButton_Click(object sender, EventArgs e)
        {
            imapClient.Disconnect(true);
        }

        private DataTable RequestsDataParser (IMailFolder folder, SearchQuery query)
        {
            DataTable requestResult = new DataTable();
            DataColumn column;
            DataRow dataRow;

            #region Задаем структуру таблицы messages
            //1. UID (уникакальный ID сообщения)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UID";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            requestResult.Columns.Add(column);

            //2. RequestNum (номер заявки на сайте Росреестра)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "RequestNum";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            requestResult.Columns.Add(column);

            //3. DocLink (ссылка на документы по выписке)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "DocLink";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            requestResult.Columns.Add(column);

            //4. AuthCode (код доступа к заявлению на сайте Росреестра)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AuthCode";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            requestResult.Columns.Add(column);

            //5. HaveSeen (признак просмотра сообщения, служебное поле)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Boolean");
            column.ColumnName = "HaveSeen";
            column.AllowDBNull = false;
            column.DefaultValue = false;
            requestResult.Columns.Add(column);

            //6. ResponseDate (Дата сообщения о готовности запроса ЕГРН)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "ResponseDate";
            column.AllowDBNull = false;
            //column.DefaultValue = false;
            requestResult.Columns.Add(column);
            #endregion

            MimeMessage message;
            string link;
            string code;
            string reqNum;
            string messageText;
            Match m;
            int limiter = 50; //Ограничитель для отладки

            folder.Open(FolderAccess.ReadOnly);
            var uids = folder.Search(query);

            foreach (var uid in uids)
            {
                //limiter--;
                //if (limiter <= 0) break;
                
                link = "";
                code = "";
                reqNum = "";
                dataRow = requestResult.NewRow();
                message = folder.GetMessage(uid);
                messageText = message.TextBody;
                m = Regex.Match(messageText, @"((?:<http:\/\/)(?<link>.+)(?:>))|((?:\[http:\/\/)(?<link>.+)(?:\]))");
                link = m.Groups["link"].Value.ToString();
                m = Regex.Match(messageText, @"(?:ключ\ )(.+)(?:\.)");
                code = m.Groups[1].Value.ToString();
                reqNum = Regex.Match(message.Subject, @"(\d{2}-\d{8})").ToString();
                dataRow["UID"] = uid.ToString();
                dataRow["RequestNum"] = reqNum;
                dataRow["DocLink"] = "http://" + @link;
                dataRow["AuthCode"] = code;
                dataRow["HaveSeen"] = true;
                dataRow["ResponseDate"] = message.Date.DateTime;
                requestResult.Rows.Add(dataRow);
                DownloadRequestsProgressBar.Invoke(new Action(() => DownloadRequestsProgressBar.Value++));

            }
            return requestResult;
        }

        private void LoadResponsesToDB (DataTable inResponses)
        {
            DataTable responsesToDB = new DataTable();
            DataColumn column;
            DataRow dataRow;

            #region Задаем структуру таблицы responsesToDB
            
            //1. RequestNum (Номер запросов)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "RequestNum";
            column.AllowDBNull = false;
            responsesToDB.Columns.Add(column);

            //2. DocLink (Ссылка на документы по запросу выписки)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "DocLink";
            column.AllowDBNull = true;
            column.DefaultValue = "";
            responsesToDB.Columns.Add(column);

            //3. AuthCode (Код авторизации для скачивания документов)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AuthCode";
            column.AllowDBNull = true;
            column.DefaultValue = "";
            responsesToDB.Columns.Add(column);

            //4. ResponseDate (дата получения ответа на запрос выписки)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "ResponseDate";
            column.AllowDBNull = true;
            responsesToDB.Columns.Add(column);

            //5. DownloadDate (дата загрузки ответа в систему управления выписками)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "DownloadDate";
            column.AllowDBNull = true;
            responsesToDB.Columns.Add(column);

            #endregion

            try
            {
                foreach (DataRow tempRow in inResponses.Rows)
                {
                    dataRow = responsesToDB.NewRow();
                    dataRow["RequestNum"] = tempRow["RequestNum"];
                    dataRow["DocLink"] = tempRow["DocLink"];
                    dataRow["AuthCode"] = tempRow["AuthCode"];
                    dataRow["ResponseDate"] = tempRow["ResponseDate"];
                    dataRow["DownloadDate"] = System.DateTime.Now;
                    responsesToDB.Rows.Add(dataRow);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось передать данные в буфер", "ОШИБКА!");
            }
            finally
            {

                try
                {
                    SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
                    stringBuilder.DataSource = Properties.Settings.Default.MSSQL_SERVER;
                    stringBuilder.InitialCatalog = Properties.Settings.Default.MSSQL_DBNAME;
                    stringBuilder.UserID = Properties.Settings.Default.MSSQL_UID;
                    stringBuilder.Password = Properties.Settings.Default.MSSQL_PASSWORD;
                    stringBuilder.IntegratedSecurity = true;

                    CSVUtility.CSVUtility.InsertDataIntoSQLServerUsingSQLBulkCopy(responsesToDB, Properties.Settings.Default.MSSQL_RESPONSE_TABLE, stringBuilder.ConnectionString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не удалось загрузить данные в базу данных: "+e.ToString(), "ОШИБКА!");                    
                }
                finally
                {
                    MessageBox.Show("Загрузка данных завершена, загружено: " + responsesToDB.Rows.Count + " записей.", "Готово!");
                }
            }
           
          
        }

        private async void DownloadRequestsDataButton_Click(object sender, EventArgs e)
        {
            DownloadRequestsDataButton.Enabled = false;
            DownloadRequestsProgressBar.Visible = true;
            DownloadRequestsProgressBar.Minimum = 0;
            DownloadRequestsProgressBar.Maximum = CountMessagesInFolder(workFolder, searchQuery);
            DownloadRequestsProgressBar.Value = 0;            

            DataTable response = null;
            try
            {
                await Task.Run(() => 
                { 
                    response = RequestsDataParser(workFolder, searchQuery);
                    LoadResponsesToDB(response);
                    //CSVUtility.CSVUtility.ToCSV(response, Properties.Settings.Default.REQ_OUT_DIR + "\\out.csv");                
                } );
            }
            catch (Exception)
            { 
                throw;
            }
            finally
            {
                MessageBox.Show("Загруженно "+ response.Rows.Count + " готовых заявок!", "Готово!");
            }

            this.requestsResponse = response;
            DownloadRequestsDataButton.Enabled = true;

        }
    }

   
}
