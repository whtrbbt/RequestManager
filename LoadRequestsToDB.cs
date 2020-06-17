using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestManager
{
    public partial class LoadRequestsToDB : Form
    {
        string requestsFilePath;
        List <string> userList = new List<string>();        

        public LoadRequestsToDB()
        {
            LoadUserListFromDB();
            InitializeComponent();
            RequestsUserSelectComboBox.DataSource = userList;

        }

        private void RequestFileLoadButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                requestsFilePath = dialog.FileName;
                RequestFilePathTextBox.Text = requestsFilePath;
            }
        }

        private void LoadUserListFromDB()
        {
            DataTable usersTable;
            string query;
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();          
            stringBuilder.DataSource = Properties.Settings.Default.MSSQL_SERVER;
            stringBuilder.InitialCatalog = Properties.Settings.Default.MSSQL_DBNAME;
            stringBuilder.UserID = Properties.Settings.Default.MSSQL_UID;
            stringBuilder.Password = Properties.Settings.Default.MSSQL_PASSWORD;
            stringBuilder.IntegratedSecurity = true;
            query = $@"select [ID], [NAME] from {Properties.Settings.Default.MSSQL_USERS_TABLE} u ORDER BY [ID] ASC";

            usersTable = CSVUtility.CSVUtility.GetDataTableFromDB(stringBuilder.ConnectionString, query);

            userList.Add("");
            foreach (DataRow dr in usersTable.Rows)
            {
                userList.Add(dr[1].ToString());
            }

        }

        private void LoadUserRequestsToDBButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Заполнены не все поля", "Внимание!");
                return;
            }
            try
            {
                LoadUserRequestsToDB (CSVUtility.CSVUtility.GetDataTableFromXLXS(requestsFilePath), RequestsUserSelectComboBox.SelectedIndex);
            }
            catch (Exception ex)
            { }
            
        }

        private void LoadUserRequestsToDB (DataTable inRequests, int UserID)
        {
            DataTable requestFromFile;
            DataTable requestsTable = new DataTable();
            DataColumn column;
            DataRow dataRow;

            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = Properties.Settings.Default.MSSQL_SERVER;
            stringBuilder.InitialCatalog = Properties.Settings.Default.MSSQL_DBNAME;
            stringBuilder.UserID = Properties.Settings.Default.MSSQL_UID;
            stringBuilder.Password = Properties.Settings.Default.MSSQL_PASSWORD;
            stringBuilder.IntegratedSecurity = true;

            #region Задаем структуру таблицы responsesToDB

            //1. CadNum (Кадастровый номер)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CadNum";
            column.AllowDBNull = false;
            requestsTable.Columns.Add(column);

            //2. ReqNum (Номер заявки)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ReqNum";
            column.AllowDBNull = false;
            requestsTable.Columns.Add(column);

            //3. CreateDate (Дата добавления заявки в БД)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "CreateDate";
            column.AllowDBNull = false;
            requestsTable.Columns.Add(column);

            //4. UserID (Идентификатор пользователя)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int16");
            column.ColumnName = "UserID";
            column.AllowDBNull = false;
            requestsTable.Columns.Add(column);

            #endregion

            try
            {
                
                foreach (DataRow dr in inRequests.Rows)
                {
                    dataRow = requestsTable.NewRow();
                    dataRow["CadNum"] = dr[0];
                    dataRow["ReqNum"] = dr[1];
                    dataRow["CreateDate"] = System.DateTime.Now;
                    dataRow["UserID"] = UserID;
                    requestsTable.Rows.Add(dataRow);
                }
                this.Enabled = false;
                CSVUtility.CSVUtility.InsertDataIntoSQLServerUsingSQLBulkCopy(requestsTable,
                    Properties.Settings.Default.MSSQL_REQUESTS, stringBuilder.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
            
            MessageBox.Show("Загрузка завершена, загруженно " + requestsTable.Rows.Count + "заявок", "Готово!");
            this.Enabled = true;
        }

        private bool ValidateForm()
        {
            if ((RequestFilePathTextBox.Text.Length < 0)||(RequestsUserSelectComboBox.SelectedIndex == 0))
                return false;
            return true;
        }
    }
}
