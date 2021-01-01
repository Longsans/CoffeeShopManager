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
            //return ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.ConnectionString"].ConnectionString;
            //return "Server = localhost; Database = NewDB; User ID = sa; Password = onetwothree; MultipleActiveResultSets = True;";
            return "Server = 192.168.43.195, 1433; Database = NewDB; User ID = sa; Password = 123456; MultipleActiveResultSets = True;";
        }
    }
}
