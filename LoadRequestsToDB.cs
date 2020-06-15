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

            DataTable requestFromFile;
            DataTable requestsTable = new DataTable();
            DataColumn column;
            DataRow dataRow;


            /// Вывести загрузку в отдельный метод!!!
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
                requestFromFile = CSVUtility.CSVUtility.GetDataTableFromXLXS(requestsFilePath);
                foreach (DataRow dr in requestFromFile.Rows)
                {
                    dataRow = requestsTable.NewRow();
                    dataRow["CadNum"] = dr[0];
                    dataRow["ReqNum"] = dr[1];
                    dataRow["CreateDate"] = System.DateTime.Now;


                }
            }
            catch (Exception ex)
            { }
        }

        private bool ValidateForm()
        {
            if ((RequestFilePathTextBox.Text.Length < 0)||(RequestsUserSelectComboBox.SelectedIndex == 0))
                return false;
            return true;
        }
    }
}
