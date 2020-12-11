using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_StockItems : DBConnection
    {
        public DTO_StockItem GetById(int id, int shopId)
        {
            DTO_StockItem item = null;
            string qry = "SELECT * FROM STOCK_ITEMS " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                item = new DTO_StockItem
                {
                    Id = (int)reader["Id"],
                    Name = reader["ItemName"].ToString(),
                    Supplier = new DTO_Supplier
                    {
                        Id = reader["SupplierId"].ToString()
                    },
                    Shop = new DTO_Shop
                    {
                        ID = (int)reader["ShopId"]
                    }
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return item;
        }

        public DTO_StockItem GetByName(string name, int shopId)
        {
            DTO_StockItem item = null;
            string qry = "SELECT * FROM STOCK_ITEMS " +
                "WHERE ItemName = @name " +
                "AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                item = new DTO_StockItem
                {
                    Id = (int)reader["Id"],
                    Name = reader["ItemName"].ToString(),
                    Supplier = new DTO_Supplier
                    {
                        Id = reader["SupplierId"].ToString()
                    },
                    Shop = new DTO_Shop
                    {
                        ID = (int)reader["ShopId"]
                    }
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return item;
        }

        public DataTable GetAllStockItems(int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], " +
                "SupplierId AS [Supplier ID] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "ORDER BY Id ASC";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableById(int id, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], " +
                "SupplierId AS [Supplier ID] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND Id = @id " +
                "ORDER BY Id ASC";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@id", id);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableByName(string name, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], " +
                "SupplierId AS [Supplier ID] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND ItemName LIKE '%' + @name + '%' " +
                "ORDER BY Id ASC";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@name", name);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableBySupplierId(string supplierId, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], " +
                "SupplierId AS [Supplier ID] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND SupplierId = @supplierId " +
                "ORDER BY Id ASC";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);
            ada.SelectCommand.Parameters.AddWithValue("@supplierId", supplierId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableBySupplierName(string supName, int shopId)
        {
            DataTable dt = new DataTable();
            DAL_Suppliers dalSup = new DAL_Suppliers();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], " +
                "SupplierId AS [Supplier ID] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND SupplierId IN (" +
                "   SELECT * " +
                "   FROM @supIds" +
                ") " +
                "ORDER BY Id ASC";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);
            var tabParam =  ada.SelectCommand.Parameters.AddWithValue("@supIds", 
                dalSup.GetDataTableSupplierIDsByName(supName, shopId));
            tabParam.SqlDbType = SqlDbType.Structured;
            tabParam.TypeName = "[dbo].Varchar10CollectionType";

            ada.Fill(dt);

            return dt;
        }

        public DTO_StockItemsForProducts GetItemForProduct(int itemId, string productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            return dalItemForPro.GetItemForProduct(itemId, productId, shopId);
        }

        public DataTable GetDataTableProductsUsingItem(int itemId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            return dalItemForPro.GetDataTableProductsUsingItem(itemId, shopId);
        }

        public void Insert(DTO_StockItem item)
        {
            string qry = "INSERT INTO STOCK_ITEMS (ItemName, SupplierId, ShopId) " +
                "VALUES (@name, @supplierId, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@supplierId", item.Supplier.Id);
            cmd.Parameters.AddWithValue("@shopId", item.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void Delete(DTO_StockItem item)
        {
            string qry = "DELETE FROM STOCK_ITEMS " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@shopId", item.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            RemoveAllItemForProductsByItemId(item.Id, item.Shop.ID);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void Update(DTO_StockItem updatedItem)
        {
            string qry = "UPDATE STOCK_ITEMS " +
                "SET ItemName = @name, SupplierId = @supId " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", updatedItem.Name);
            cmd.Parameters.AddWithValue("@supId", updatedItem.Supplier.Id);
            cmd.Parameters.AddWithValue("@id", updatedItem.Id);
            cmd.Parameters.AddWithValue("@shopId", updatedItem.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void AddItemForProduct(DTO_StockItemsForProducts itemForPro)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            dalItemForPro.Insert(itemForPro);
        }

        public void RemoveItemForProduct(DTO_StockItemsForProducts itemForPro)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            dalItemForPro.Delete(itemForPro);
        }

        public void RemoveAllItemForProductsByItemId(int itemId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            dalItemForPro.DeleteAllByItemId(itemId, shopId);
        }

        public int GetNextItemId(int shopId)
        {
            int currentId = -1;
            string qry = "SELECT ISNULL(max(Id), 0) " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var obj = cmd.ExecuteScalar();
            if (obj != null)
            {
                currentId = (int)obj;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return currentId + 1;
        }
    }
}
