using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        protected string connectionString = "Server=tcp:one-server.database.windows.net,1433;" +
            "Initial Catalog=OneDB;" +
            "Persist Security Info=False;" +
            "User ID=Longsans;" +
            "Password=OneBigServer123;" +
            "MultipleActiveResultSets=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";
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
