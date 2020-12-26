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
    internal class DAL_StockItemsForProducts : DBConnection
    {
        public DAL_StockItemsForProducts(string connString) : base(connString)
        {

        }

        public DTO_StockItemForProduct GetItemForProduct(int itemId, int productId, int shopId)
        {
            DTO_StockItemForProduct itemForPro = null;
            string qry = "SELECT * FROM STOCK_ITEMS_FOR_PRODUCTS " +
                "WHERE ItemId = @itemId " +
                "AND ProductId = @productId " +
                "AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                itemForPro = new DTO_StockItemForProduct
                {
                    Item = new DTO_StockItem
                    {
                        Id = (int)reader["ItemId"],
                        Shop = new DTO_Shop
                        {
                            ID = (int)reader["ShopId"]
                        }
                    },
                    Product = new DTO_Product
                    {
                        Id = (int)reader["ProductId"],
                        Shop = new DTO_Shop
                        {
                            ID = (int)reader["ShopId"]
                        }
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

            return itemForPro;
        }

        public DataTable GetDataTableProductsUsingItem(int itemId, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT ProductId AS [Product ID], Name AS [Product Name] " +
                "FROM STOCK_ITEMS_FOR_PRODUCTS " +
                "INNER JOIN PRODUCTS " +
                "ON STOCK_ITEMS_FOR_PRODUCTS.ProductId = PRODUCTS.Id " +
                "AND STOCK_ITEMS_FOR_PRODUCTS.ShopId = PRODUCTS.ShopId " +
                "WHERE ItemId = @itemId " +
                "AND STOCK_ITEMS_FOR_PRODUCTS.ShopId = @shopId " +
                "AND PRODUCTS.Deleted = 0";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@itemId", itemId);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableItemsOfProduct(int productId, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT ItemId AS [Item ID], ItemName AS [Item Name] " +
                "FROM STOCK_ITEMS_FOR_PRODUCTS " +
                "INNER JOIN STOCK_ITEMS " +
                "ON STOCK_ITEMS_FOR_PRODUCTS.ItemId = STOCK_ITEMS.Id " +
                "AND STOCK_ITEMS_FOR_PRODUCTS.ShopId = STOCK_ITEMS.ShopId " +
                "WHERE ProductId = @productId " +
                "AND STOCK_ITEMS_FOR_PRODUCTS.ShopId = @shopId";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@productId", productId);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public void Insert(DTO_StockItemForProduct itemForPro)
        {
            string qry = "INSERT INTO STOCK_ITEMS_FOR_PRODUCTS " +
                "VALUES (@proId, @itemId, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@proId", itemForPro.Product.Id);
            cmd.Parameters.AddWithValue("@itemId", itemForPro.Item.Id);
            cmd.Parameters.AddWithValue("@shopId", itemForPro.Shop.ID);

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

        public void Delete(DTO_StockItemForProduct itemForPro)
        {
            string qry = "DELETE FROM STOCK_ITEMS_FOR_PRODUCTS " +
                "WHERE ProductId = @proId " +
                "AND ItemId = @itemId " +
                "AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@proId", itemForPro.Product.Id);
            cmd.Parameters.AddWithValue("@itemId", itemForPro.Item.Id);
            cmd.Parameters.AddWithValue("@shopId", itemForPro.Shop.ID);

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

        public void DeleteAllByProductId(int productId, int shopId)
        {
            string qry = "DELETE FROM STOCK_ITEMS_FOR_PRODUCTS " +
                "WHERE ProductId = @proId " +
                "AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@proId", productId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

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

        public void DeleteAllByItemId(int itemId, int shopId)
        {
            string qry = "DELETE FROM STOCK_ITEMS_FOR_PRODUCTS " +
                "WHERE ItemId = @itemId " +
                "AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

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
    }
}
