using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_StockItems
    {
        DAL_StockItems dalStock = new DAL_StockItems();

        public DTO_StockItem GetById(string id, int shopId)
        {
            return dalStock.GetById(id, shopId);
        }

        public DataTable GetAllStockItems(int shopId)
        {
            return dalStock.GetAllStockItems(shopId);
        }

        public DataTable GetDataTableById(string id, int shopId)
        {
            return dalStock.GetDataTableById(id, shopId);
        }

        public DataTable GetDataTableByName(string name, int shopId)
        {
            return dalStock.GetDataTableByName(name, shopId);
        }

        public DataTable GetDataTableBySupplierId(string supplierId, int shopId)
        {
            return dalStock.GetDataTableBySupplierId(supplierId, shopId);
        }

        public void Insert(DTO_StockItem item)
        {
            dalStock.Insert(item);
        }

        public void Delete(DTO_StockItem item)
        {
            dalStock.Delete(item);
        }

        public void Update(DTO_StockItem updatedItem)
        {
            dalStock.Update(updatedItem);
        }
    }
}
