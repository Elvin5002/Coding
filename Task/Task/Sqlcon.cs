using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Task
{
    public class Sqlcon
    {
        const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=task;Integrated Security=True";

        public int ExecuteNonQuery(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();
            return result;
        }

        public DataTable ExecuteReader(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            sqlCommand.Dispose();
            sqlDataReader.Close();
            sqlConnection.Close();
            return dataTable;
        }
    }
}
