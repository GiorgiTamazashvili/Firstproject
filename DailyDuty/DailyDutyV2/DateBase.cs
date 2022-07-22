using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DailyDutyV2
{
    class DateBase
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tgior\source\repos\DailyDuty\DailyDutyV2\Database1.mdf;Integrated Security = True");

        public void OpenConnection() 
        {

            if (sqlConnection.State== System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection() 
        {
        
        
            return sqlConnection;
        }

    }
}
