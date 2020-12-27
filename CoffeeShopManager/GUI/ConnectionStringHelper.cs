using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GUI
{
    public static class ConnectionStringHelper
    {
        public static string GetConnectionString()
        {
            //return ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.ConnectionStringCuong"].ConnectionString;
            return "Data Source=localhost; Initial Catalog=NewDB; User id=sa;Password=onetwothree;MultipleActiveResultSets=True;";
            //return "Server = 10.0.131.2\\SQLEXPRESS,1433; Database = NewDB; User ID = sa; Password = 123456; MultipleActiveResultSets = True";
        }
    }
}
