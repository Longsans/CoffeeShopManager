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
            return ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.ConnectionString"].ConnectionString;
        }
    }
}
