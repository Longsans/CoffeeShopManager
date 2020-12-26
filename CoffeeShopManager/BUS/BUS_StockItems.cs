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
        private string connectionString;
        DAL_StockItems dalStock;

        public BUS_StockItems(string connString)
        {
            connectionString = connString;
            dalStock = new DAL_StockItems(connectionString);
        }

        public DTO_StockItem GetById(int id, int shopId)
        {
            return dalStock.GetById(id, shopId);
        }

        public DTO_StockItem GetByName(string name, int shopId)
        {
            return dalStock.GetByName(name, shopId);
        }

        public DataTable GetAllStockItems(int shopId)
        {
            return dalStock.GetAllStockItems(shopId);
        }

        public DataTable GetDataTableById(int id, int shopId)
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

        public DataTable GetDataTableBySupplierName(string supName, int shopId)
        {
            return dalStock.GetDataTableBySupplierName(supName, shopId);
        }

        public DataTable GetDataTableProductsUsingItem(int itemId, int shopId)
        {
            return dalStock.GetDataTableProductsUsingItem(itemId, shopId);
        }

        public DTO_StockItemForProduct GetItemForProduct(int itemId, int productId, int shopId)
        {
            return dalStock.GetItemForProduct(itemId, productId, shopId);
        }

        public void AddItemForProduct(DTO_StockItemForProduct itemForPro)
        {
            dalStock.AddItemForProduct(itemForPro);
        }

        public void RemoveItemForProduct(DTO_StockItemForProduct itemForPro)
        {
            dalStock.RemoveItemForProduct(itemForPro);
        }

        public void RemoveAllItemForProductsByItemId(int itemId, int shopId)
        {
            dalStock.RemoveAllItemForProductsByItemId(itemId, shopId);
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

        public int GetNextItemId(int shopId)
        {
            return dalStock.GetNextItemId(shopId);
        }
    }
}
