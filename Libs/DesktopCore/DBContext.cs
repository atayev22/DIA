using DesktopCore.Classes;
using Microsoft.Data.SqlClient;
using System;

namespace DesktopCore
{
    public static class DBContext
    {
        private static string connectionString = "Server=WIN-QEMS5K9DNV9\\SQLEXPRESS;Database=DIA;Encrypt=false;Trusted_Connection=True;";

        private static SqlConnection sqlConnection;

        private static SqlCommand sqlCommand;
        private static SqlDataReader reader;

        //public static bool DBCheck(string sql)
        //{
        //    sqlConnection = new SqlConnection(connectionString);
        //    sqlCommand = new SqlCommand(sql, sqlConnection);
        //    reader = sqlCommand.ExecuteReader();
        //    try
        //    {
                
        //        sqlConnection.Open();
        //        return reader.Read();
                
        //    }

        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //}
        public static int Execute(string sql) 
        {
            
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);
            
            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            
            finally
            {
                sqlConnection.Close();
            }
        }


    }
}
