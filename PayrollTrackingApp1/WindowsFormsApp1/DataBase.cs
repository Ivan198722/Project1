using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollTrackingApp1
{
    public class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=desktop-d7kosmm;Initial Catalog=PayrollTrackingDB;Integrated Security=True");

        public void OpenConection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            { sqlConnection.Open(); }
        }

        public void CloseConection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            { sqlConnection.Close(); }
        }

        public SqlConnection GetConnection()
        { return sqlConnection; }
    }
}
