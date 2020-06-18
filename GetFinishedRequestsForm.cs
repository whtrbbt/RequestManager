using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestManager
{
    public partial class GetFinishedRequestsForm : Form
    {
        List<string> userList = new List<string>();

        public GetFinishedRequestsForm()
        {
            LoadUserListFromDB();
            InitializeComponent();
            //SelectRequestsUserComboBox.Font.Italic = true;


        }

        private void SelectRequestsUserComboBox_Enter(object sender, EventArgs e)
        {
            SelectRequestsUserComboBox.Text = "";
            SelectRequestsUserComboBox.DataSource = userList;
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

            userList.Add("*Все*");
            foreach (DataRow dr in usersTable.Rows)
            {
                userList.Add(dr[1].ToString());
            }

        }
    }
}
