using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Suppliers
    {
        private string connectionString;
        DAL_Suppliers dalSup;

        public BUS_Suppliers(string connString)
        {
            connectionString = connString;
            dalSup = new DAL_Suppliers(connectionString);
        }

        public DTO_Supplier GetById(string id, int shopId)
        {
            return dalSup.GetById(id, shopId);
        }

        public DTO_Supplier GetByEmail(string email, int shopId)
        {
            return dalSup.GetByEmail(email, shopId);
        }

        public DataTable GetAllSuppliers(int shopId)
        {
            return dalSup.GetAllSuppliers(shopId);
        }

        public DataTable GetDataTableById(string id, int shopId)
        {
            return dalSup.GetDataTableById(id, shopId);
        }

        public DataTable GetDataTableByName(string name, int shopId)
        {
            return dalSup.GetDataTableByName(name, shopId);
        }

        public DataTable GetDataTableByEmail(string email, int shopId)
        {
            return dalSup.GetDataTableByEmail(email, shopId);
        }

        public DataTable GetDataTableByPhoneNumber(string phone, int shopId)
        {
            return dalSup.GetDataTableByPhoneNumber(phone, shopId);
        }

        public void Insert(DTO_Supplier sup)
        {
            dalSup.Insert(sup);
        }

        public void Delete(DTO_Supplier sup)
        {
            dalSup.Delete(sup);
        }

        public void Update(DTO_Supplier sup)
        {
            dalSup.Update(sup);
        }
    }
}
