using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CursoWindowsFormBiblioteca.Databases
{
    public class SQLServerClass
    {
        public string stringConn;
        public SqlConnection connDB;

        public SQLServerClass()
        {
            try
            {
                stringConn = ConfigurationManager.ConnectionStrings["Fichario"].ConnectionString;
                connDB = new SqlConnection(stringConn);
                connDB.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(sql, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string SQLCommand(string sql)
        {
            try
            {
                var myCommand = new SqlCommand(sql, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            connDB.Close();
        }

    }
}
