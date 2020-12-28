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
        public DAL_Tables(string connString) : base(connString)
        {

        }

        public DTO_Table GetTableByIdNotDeleted(int tableId, int shopId)
        {
            DTO_Table tab = null;
            string qry = "SELECT * FROM [TABLES] " +
                "WHERE Id = @id AND ShopId = @shopId AND Deleted = 0";
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
                    },
                    Deleted = (bool)reader["Deleted"]
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return tab;
        }

        public DTO_Table GetTableByIdDeletedAndNotDeleted(int tableId, int shopId)
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
                    },
                    Deleted = (bool)reader["Deleted"]
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return tab;
        }

        public List<DTO_Table> GetAllNotDeletedTablesByShopId(int shopId)
        {
            List<DTO_Table> tabList = new List<DTO_Table>();
            string qry = "SELECT * FROM [TABLES] " +
                "WHERE ShopId = @shopId AND Deleted = 0";
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
                    },
                    Deleted = (bool)reader["Deleted"]
                };
                tabList.Add(table);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return tabList;
        }

        private List<DTO_Table> GetNotDeletedTablesByStatus(string status, int shopId)
        {
            List<DTO_Table> tabList = new List<DTO_Table>();
            string qry = "SELECT * FROM [TABLES] " +
                "WHERE TableStatus = @status AND ShopId = @shopId AND Deleted = 0";
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
                    },
                    Deleted = (bool)reader["Deleted"]
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
            return GetNotDeletedTablesByStatus("Available", shopId);
        }

        public List<DTO_Table> GetOccupiedTables(int shopId)
        {
            return GetNotDeletedTablesByStatus("Occupied", shopId);
        }

        public List<DTO_Table> GetUnavailableTables(int shopId)
        {
            return GetNotDeletedTablesByStatus("Unavailable", shopId);
        }

        public DTO_Table GetTableOfActiveReceipt(int receiptId, int shopId)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting(this.connectionString);
            return dalTabSitting.GetTableOfActiveReceipt(receiptId, shopId);
        }

        public DTO_Receipt GetCurrentReceiptOfTable(int tableId, int shopId)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting(this.connectionString);
            DTO_Table tab = GetTableByIdNotDeleted(tableId, shopId);
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

        public DataTable GetCurrentReceiptIdsAtTable(int tableId, int shopId)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting(this.connectionString);
            DataTable dt = new DataTable();
            DTO_Table tab = GetTableByIdDeletedAndNotDeleted(tableId, shopId);

            if (tab != null)
            {
                if (tab.Status == "Occupied")
                {
                    dt = dalTabSitting.GetCurrentReceiptIdsAtTable(tableId, shopId);
                }
            }

            return dt;
        }

        public bool CheckReceiptExists(DTO_Table tab)
        {
            bool res;
            string qry = "SELECT * " +
                "FROM TABLE_SITTING " +
                "WHERE TableId = @tabId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@tabId", tab.Id);
            cmd.Parameters.AddWithValue("@shopId", tab.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                res = true;
            }
            else
            {
                res = false;
            }

            if (!connState)
            {
                CloseConnection();
            }

            return res;
        }

        public void Insert(DTO_Table tab)
        {
            string qry = "INSERT INTO [TABLES] (Id, TableStatus, ShopId, Deleted) " +
                "VALUES (@id, @status, @shopId, @del)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", tab.Id);
            cmd.Parameters.AddWithValue("@status", tab.Status);
            cmd.Parameters.AddWithValue("@shopId", tab.Shop.ID);
            cmd.Parameters.AddWithValue("@del", 0);

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

        public void FalseDelete(DTO_Table tab)
        {
            string qry = "UPDATE [TABLES] " +
                "SET Deleted = 1 " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", tab.Id);
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

        public void TrueDelete(DTO_Table tab)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting(this.connectionString);
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

        public void RestoreDeletedTable(DTO_Table tab)
        {
            string qry = "UPDATE [TABLES] " +
                "SET Deleted = 0 " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", tab.Id);
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

        public void Update(DTO_Table tabUpdated)
        {
            DAL_TableSitting dalTabSit = new DAL_TableSitting(this.connectionString);
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
            if (tabUpdated.Status == "Available")
            {
                var tabsit = new DTO_TableSitting
                {
                    Table = tabUpdated,
                    Sitting = false
                };
                dalTabSit.Update(tabsit);
            }
            if (!connState)
            {
                CloseConnection();
            }
        }
    }
}
