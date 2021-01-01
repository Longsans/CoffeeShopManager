using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Workers
    {
        private string connectionString;
        DAL_Workers dalWorkers;

        public BUS_Workers(string connString)
        {
            connectionString = connString;
            dalWorkers = new DAL_Workers(connectionString);
        }

        public DTO_Worker GetById(string id, int shopId)
        {
            return dalWorkers.GetById(id, shopId);
        }

        public DTO_Worker GetByEmail(string email, int shopId)
        {
            return dalWorkers.GetByEmail(email, shopId);
        }

        public DTO_Worker GetByUsername(string username)
        {
            return dalWorkers.GetByUsername(username);
        }
    }
}
