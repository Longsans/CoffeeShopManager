using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBConnection
    {
        protected string connectionString = ConfigurationManager.ConnectionStrings["OneDB"].ConnectionString;
        protected SqlConnection conn = null;

        public DBConnection()
        {
            this.conn = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            this.conn.Open();
        }

        public void CloseConnection()
        {
            this.conn.Close();
        }
    }
}
