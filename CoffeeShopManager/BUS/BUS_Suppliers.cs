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
        DAL_Suppliers dalSup = new DAL_Suppliers();

        public DTO_Supplier GetById(string id, int shopId)
        {
            return dalSup.GetById(id, shopId);
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
