using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RequestManager
{
    public partial class ProcessReqFileFromInDirForm : Form
    {

        static DataTable responsesFromDB;
        SqlConnectionStringBuilder stringBuilder;


        public ProcessReqFileFromInDirForm()
        {
            stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = Properties.Settings.Default.MSSQL_SERVER;
            stringBuilder.InitialCatalog = Properties.Settings.Default.MSSQL_DBNAME;
            stringBuilder.UserID = Properties.Settings.Default.MSSQL_UID;
            stringBuilder.Password = Properties.Settings.Default.MSSQL_PASSWORD;
            stringBuilder.IntegratedSecurity = true;
            GetResponsesFromDB();
            InitializeComponent();
            
            
        }


        private void GetResponsesFromDB ()
        {
            string query;
            query = $@"SELECT [ID] 
                    ,[RequestNum]
                    ,[DocLink]
                    ,[AuthCode]
                FROM {Properties.Settings.Default.MSSQL_RESPONSE_TABLE} r
                where 1=1
                order by [ID] DESC";

            responsesFromDB = CSVUtility.CSVUtility.GetDataTableFromDB(stringBuilder.ConnectionString, query);
        }

        private static DataTable GetReqFromFile (string filename, bool header = true)
        {
            DataTable reqFromFile = new DataTable();
            DataRow dataRow;
            DataColumn column;

            #region Задаем структуру таблицы reqFromFile

            //1. CadNum (Кадастровый номер)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CadNum";
            column.AllowDBNull = false;
            reqFromFile.Columns.Add(column);

            //2. ReqNum (Номер заявки)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ReqNum";
            column.AllowDBNull = false;
            reqFromFile.Columns.Add(column);

            #endregion

            DataTable tempTable = null;
            
            try
            {
                tempTable = CSVUtility.CSVUtility.GetDataTableFromXLXS(filename, header);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!");
            }

            if (tempTable != null)                
            {
                foreach (DataRow dr in tempTable.Rows)
                {
                    dataRow = reqFromFile.NewRow();
                    dataRow["CadNum"] = dr[0].ToString().Trim();
                    dataRow["ReqNum"] = dr[1].ToString().Trim();
                    reqFromFile.Rows.Add(dataRow);
                }
            }
            

            return reqFromFile;
        }

        private static DataTable JoinResponsesAndRequests (DataTable requests)
        {
            DataTable result = new DataTable();
            DataColumn column;
            DataRow dataRow;

            #region Задаем структуру таблицы result
            //1. UID (уникакальный ID сообщения)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CadNum";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            result.Columns.Add(column);

            //2. RequestNum (номер заявки на сайте Росреестра)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "RequestNum";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            result.Columns.Add(column);

            //3. DocLink (ссылка на документы по выписке)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "DocLink";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            result.Columns.Add(column);

            //4. AuthCode (код доступа к заявлению на сайте Росреестра)
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AuthCode";
            column.AllowDBNull = false;
            column.DefaultValue = "";
            result.Columns.Add(column);

            #endregion

            var tempDataTable = from dr in requests.AsEnumerable()
                                join rr in responsesFromDB.AsEnumerable() on dr[1] equals rr[1] into gj
                                from subreq in gj.DefaultIfEmpty()
                                select new { CadNum = dr[0], ReqNum = dr[1], Link = subreq?[2] ?? String.Empty, Code = subreq?[3] ?? String.Empty };
            
            foreach (var tr in tempDataTable)
            {
                dataRow = result.NewRow();
                dataRow["CadNum"] = tr.CadNum.ToString();
                dataRow["RequestNum"] = tr.ReqNum.ToString();
                dataRow["DocLink"] = tr.Link.ToString();
                dataRow["AuthCode"] = tr.Code.ToString();
                result.Rows.Add(dataRow);
            }

            return result;
        }

        public void CheckRequestFromDir(string inDir, string outDir, bool clearOutDir = false)
        // Проверяет папку inDir на наличие подпапок, очищает папку outDir, создает подпапки в папке outDir, запускает проверку файлов запросов в папках
        {
            var dirIN = new DirectoryInfo(@inDir); //папка с входящими файлами 
            var dirOUT = new DirectoryInfo(@outDir+"\\"); //папка с исходящими файлами  
            string dirName = "";
            if (clearOutDir)
            {
                try
                {
                    dirOUT.Delete(true);
                    dirOUT.Create();
                }
                catch (SystemException ex)
                {
                    throw ex;
                }
            }
            foreach (DirectoryInfo dir in dirIN.GetDirectories()) //ищем все подкаталоги в каталоге dirIN
            {
                dirName = Path.GetFileName(dir.FullName); //получаем имя текущего подкаталога
                Console.WriteLine(dirName);
                dirName = dirOUT + @"\" + dirName;
                if (!Directory.Exists(dirName))
                    Directory.CreateDirectory(dirName);
                CheckRequestFromDir(dir.FullName, dirName);

            }
            CheckRequestFromFiles(dirIN.FullName, dirOUT.FullName);
        }

        static void CheckRequestFromFiles(string inDir, string outDir)
        // Проверяет статус запросов по всем файлам в папке inDir
        {
            var dirIN = new DirectoryInfo(@inDir); // папка с входящими файлами 
            var dirOUT = new DirectoryInfo(@outDir); // папка с исходящими файлами             
            string fileName = "";

            foreach (FileInfo file in dirIN.GetFiles())
            {
                fileName = Path.GetFileName(file.FullName);
                Console.WriteLine(fileName);
                CheckRequestFromFile(@file.FullName, @outDir + fileName);
            }
        }

        private static void CheckRequestFromFile(string inFileName, string outFileName)
        {
            DataTable tempTable;
            tempTable = GetReqFromFile(inFileName);            
            CSVUtility.CSVUtility.ToXLSX(JoinResponsesAndRequests(tempTable), outFileName);

        }



        private void ProcessReqFileFromInDirForm_Load(object sender, EventArgs e)
        {

        }

        private void ProcessReqFileFromInDirForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
