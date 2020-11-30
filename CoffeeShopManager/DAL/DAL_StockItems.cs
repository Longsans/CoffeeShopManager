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
        public DTO_StockItem GetById(string id, int shopId)
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
                    Id = reader["Id"].ToString(),
                    Name = reader["ItemName"].ToString(),
                    Supplier = new DTO_Supplier
                    {
                        Id = reader["SupplierId"].ToString()
                    },
                    Shop = new DTO_Shop
                    {
                        ID = (int)reader["ShopId"]
                    },
                    Quantity = (int)reader["Quantity"],
                    InventoryUnit = reader["InventoryUnit"].ToString()
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
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], SupplierId AS [Supplier ID], " +
                "Quantity, InventoryUnit AS [Inventory Unit] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableById(string id, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], SupplierId AS [Supplier ID], " +
                "Quantity, InventoryUnit AS [Inventory Unit] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND Id = @id";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@id", id);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableByName(string name, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], SupplierId AS [Supplier ID], " +
                "Quantity, InventoryUnit AS [Inventory Unit] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND ItemName LIKE '%' + @name + '%'";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@name", name);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableBySupplierId(string supplierId, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, ItemName AS [Item Name], SupplierId AS [Supplier ID], " +
                "Quantity, InventoryUnit AS [Inventory Unit] " +
                "FROM STOCK_ITEMS " +
                "WHERE ShopId = @shopId " +
                "AND SupplierId = @supplierId";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);
            ada.SelectCommand.Parameters.AddWithValue("@supplierId", supplierId);

            ada.Fill(dt);

            return dt;
        }

        public void Insert(DTO_StockItem item)
        {
            string qry = "INSERT INTO STOCK_ITEMS " +
                "VALUES (@id, @name, @supplierId, @shopId, @quantity, @unit)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@supplierId", item.Supplier.Id);
            cmd.Parameters.AddWithValue("@shopId", item.Shop.ID);
            cmd.Parameters.AddWithValue("@quantity", item.Quantity);
            cmd.Parameters.AddWithValue("@unit", item.InventoryUnit);

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

            //

            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void Update(DTO_StockItem updatedItem)
        {
            string qry = "UPDATE STOCK_ITEMS " +
                "SET ItemName = @name, SupplierId = @supId, " +
                "Quantity = @quantity, InventoryUnit = @unit " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", updatedItem.Name);
            cmd.Parameters.AddWithValue("@supId", updatedItem.Supplier.Id);
            cmd.Parameters.AddWithValue("@quantity", updatedItem.Quantity);
            cmd.Parameters.AddWithValue("@unit", updatedItem.InventoryUnit);
            cmd.Parameters.AddWithValue("@id", updatedItem.Id);
            cmd.Parameters.AddWithValue("@shopId", updatedItem.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }

            //

            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }
    }
}
