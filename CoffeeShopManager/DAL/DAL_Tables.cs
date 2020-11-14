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
    public class DAL_Tables : DBConnection
    {
        public DTO_Table GetTableById(int tableId, int shopId)
        {
            DTO_Table tab = null;
            string qry = "SELECT * FROM [TABLES] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", tableId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tab = new DTO_Table
                {
                    Id = tableId,
                    Status = reader.GetString(reader.GetOrdinal("TableStatus")),
                    Shop = new DTO_Shop
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ShopId"))
                    }
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return tab;
        }

        public List<DTO_Table> GetTablesByShopId(int shopId)
        {
            List<DTO_Table> tabList = new List<DTO_Table>();
            string qry = "SELECT * FROM [TABLES] " +
                "WHERE ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var table = new DTO_Table
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Status = reader.GetString(reader.GetOrdinal("TableStatus")),
                    Shop = new DTO_Shop
                    {
                        ID = shopId
                    }
                };
                tabList.Add(table);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return tabList;
        }

        private List<DTO_Table> GetTablesByStatus(string status, int shopId)
        {
            List<DTO_Table> tabList = new List<DTO_Table>();
            string qry = "SELECT * FROM [TABLES] " +
                "WHERE TableStatus = @status AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            
            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var table = new DTO_Table
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Status = status,
                    Shop = new DTO_Shop
                    {
                        ID = shopId
                    }
                };
                tabList.Add(table);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return tabList;
        }

        public List<DTO_Table> GetAvailableTables(int shopId)
        {
            return GetTablesByStatus("Available", shopId);
        }

        public List<DTO_Table> GetOccupiedTables(int shopId)
        {
            return GetTablesByStatus("Occupied", shopId);
        }

        public List<DTO_Table> GetUnavailableTables(int shopId)
        {
            return GetTablesByStatus("Unavailable", shopId);
        }

        public DTO_Receipt GetCurrentReceiptOfTable(int tableId, int shopId)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            DTO_Table tab = GetTableById(tableId, shopId);
            DTO_Receipt rec = null;

            if (tab != null)
            {
                if (tab.Status == "Occupied")
                {
                    rec = dalTabSitting.GetLatestReceiptAtTable(tableId, shopId);
                }
            }

            return rec;
        }

        public void Insert(DTO_Table tab)
        {
            string qry = "INSERT INTO [TABLES] " +
                "VALUES (@id, @status, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", tab.Id);
            cmd.Parameters.AddWithValue("@status", tab.Status);
            cmd.Parameters.AddWithValue("@shopId", tab.Shop.ID);

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

        public void Delete(DTO_Table tab)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            string qry = "DELETE FROM [TABLES] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", tab.Id);
            cmd.Parameters.AddWithValue("@shopId", tab.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalTabSitting.DeleteAllSittingsAtTable(tab);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void Update(DTO_Table tabUpdated)
        {
            string qry = "UPDATE [TABLES] " +
                "SET TableStatus = @status " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@status", tabUpdated.Status);
            cmd.Parameters.AddWithValue("@id", tabUpdated.Id);
            cmd.Parameters.AddWithValue("@shopId", tabUpdated.Shop.ID);

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
