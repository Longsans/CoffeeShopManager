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
    internal class DAL_TableSitting : DBConnection
    {
        public DAL_TableSitting(string connString) : base(connString)
        {

        }

        public DTO_Table GetTableOfReceipt(int receiptId, int shopId)
        {
            DTO_Table tab = null;
            string qry = "SELECT * FROM TABLE_SITTING " +
                "WHERE ReceiptId = @receiptId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@receiptId", receiptId);
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
                    Id = reader.GetInt32(reader.GetOrdinal("TableId")),
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

        public DTO_Table GetTableOfActiveReceipt(int receiptId, int shopId)
        {
            DTO_Table tab = null;
            string qry = "SELECT * " +
                "FROM TABLE_SITTING " +
                "WHERE ReceiptId = @recId AND ShopId = @shopId AND Sitting = 1";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@receiptId", receiptId);
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
                    Id = reader.GetInt32(reader.GetOrdinal("TableId")),
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

        public DTO_Receipt GetLatestReceiptAtTable(int tableId, int shopId)
        {
            DTO_Receipt rec = null;
            DAL_Receipts dalRec = new DAL_Receipts(this.connectionString);
            string qry = "SELECT ReceiptId FROM TABLE_SITTING " +
                "WHERE ReceiptId >= ALL( " +
                "SELECT ReceiptId FROM TABLE_SITTING " +
                "WHERE TableId = @tableId AND ShopId = @shopId " +
                ") AND ShopId = @shopId AND Sitting = 1";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@tableId", tableId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rec = dalRec.GetReceiptById(reader.GetInt32(reader.GetOrdinal("ReceiptId")), shopId);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return rec;
        }

        public DataTable GetCurrentReceiptIdsAtTable(int tableId, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT ReceiptId " +
                "FROM TABLE_SITTING " +
                "WHERE TableId = @tableId AND ShopId = @shopId AND Sitting = 1";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@tableId", tableId);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public void Insert(DTO_TableSitting tabSit)
        {
            string qry = "INSERT INTO TABLE_SITTING " +
                "VALUES (@receiptId, @tableId, @shopId, @sitting)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@receiptId", tabSit.Receipt.Id);
            cmd.Parameters.AddWithValue("@tableId", tabSit.Table.Id);
            cmd.Parameters.AddWithValue("@shopId", tabSit.Receipt.Shop.ID);
            cmd.Parameters.AddWithValue("@sitting", tabSit.Sitting);

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

        public void Delete(DTO_Receipt rec, int tableId)
        {
            string qry = "DELETE FROM TABLE_SITTING " +
                "WHERE ReceiptId = @recId AND TableId = @tableId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@recId", rec.Id);
            cmd.Parameters.AddWithValue("@tableId", tableId);
            cmd.Parameters.AddWithValue("@shopId", rec.Shop.ID);

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

        public void DeleteAllSittingsAtTable(DTO_Table tab)
        {
            string qry = "DELETE FROM TABLE_SITTING " +
                "WHERE TableId = @tableId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@tableId", tab.Id);
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

        public void DeleteAllSittingsByReceipt(DTO_Receipt rec)
        {
            string qry = "DELETE FROM TABLE_SITTING " +
                "WHERE ReceiptId = @recId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@recId", rec.Id);
            cmd.Parameters.AddWithValue("@shopId", rec.Shop.ID);

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

        public void Update(DTO_TableSitting tabSit)
        {
            string qry = "UPDATE TABLE_SITTING " +
                "SET Sitting = @sitting " +
                "WHERE TableId = @tabId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@tabId", tabSit.Table.Id);
            cmd.Parameters.AddWithValue("@shopId", tabSit.Table.Shop.ID);
            cmd.Parameters.AddWithValue("@sitting", tabSit.Sitting);

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
