using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Db
    {
        const string connectionString = @"Data Source=SQL5070.site4now.net;Initial Catalog=db_a44c72_bmu;User Id=db_a44c72_bmu_admin;Password=BMU!@345";
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
        public int ExecuteNonQuery(string sql)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
            return result;
        }
        public DataTable ExecuteReader(string sql)
        {
            DataTable dataTable = new DataTable();
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
