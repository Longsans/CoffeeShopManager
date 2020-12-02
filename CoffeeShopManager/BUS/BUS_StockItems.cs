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

        public DTO_StockItem GetByName(string name, int shopId)
        {
            return dalStock.GetByName(name, shopId);
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

        public DataTable GetDataTableBySupplierName(string name, int shopId)
        {
            return dalStock.GetDataTableBySupplierName(name, shopId);
        }

        public DataTable GetDataTableProductsUsingItem(string itemId, int shopId)
        {
            return dalStock.GetDataTableProductsUsingItem(itemId, shopId);
        }

        public DTO_StockItemsForProducts GetItemForProduct(string itemId, string productId, int shopId)
        {
            return dalStock.GetItemForProduct(itemId, productId, shopId);
        }

        public void AddItemForProduct(DTO_StockItemsForProducts itemForPro)
        {
            dalStock.AddItemForProduct(itemForPro);
        }

        public void RemoveItemForProduct(DTO_StockItemsForProducts itemForPro)
        {
            dalStock.RemoveItemForProduct(itemForPro);
        }

        public void RemoveAllProductsUsingItemByItemId(string itemId, int shopId)
        {
            dalStock.RemoveAllProductsUsingItemByItemId(itemId, shopId);
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
