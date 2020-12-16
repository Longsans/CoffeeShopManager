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
        protected string connectionString = Properties.Settings.Default.ConnectionString;
        //"Data Source=HDM-PC-DC54PLF;Initial Catalog=NewDB;Integrated Security=True";
        //"Data Source=DESKTOP-14KFC4R\SQLEXPRESS; Initial Catalog=NewDB; User id=sa;Password=123456;" 
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
