using DesktopCore.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DesktopCore
{
    public static class DBContext
    {
        private static string connectionString = "Server=WIN-QEMS5K9DNV9\\SQLEXPRESS;Database=DIA;Encrypt=false;Trusted_Connection=True;";

        private static SqlConnection sqlConnection;

        public static SqlCommand sqlCommand;

        public static SqlDataAdapter sqlDataAdapter;

        public static int ExCheck(string sql)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();               
                if (sqlCommand.ExecuteScalar() == null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(sqlCommand.ExecuteScalar().ToString());
                }

            }
            catch
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
        
        public static int Execute(string sql) 
        {
            
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);
            
            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
            
            finally
            {
                sqlConnection.Close();
            }
        }

        public static DataSet ExecuteData(string sql)
        {

            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();

            try
            {
                sqlConnection.Open(); 
                sqlDataAdapter.Fill(ds);
                return ds;
            }
            

            finally
            {
                sqlConnection.Close();
            }
        }


    }
}
