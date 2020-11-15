﻿using System;
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
        public DTO_Table GetTableOfReceipt(int receiptId)
        {
            DTO_Table tab = null;
            string qry = "SELECT * FROM TABLE_SITTING " +
                "WHERE ReceiptId = @receiptId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@receiptId", receiptId);

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
            DAL_Receipts dalRec = new DAL_Receipts();
            string qry = "SELECT ReceiptId FROM TABLE_SITTING " +
                "WHERE ReceiptId >= ALL( " +
                "SELECT ReceiptId FROM TABLE_SITTING " +
                "WHERE TableId = @tableId AND ShopId = @shopId " +
                ")";
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
                rec = dalRec.GetReceiptById(reader.GetInt32(reader.GetOrdinal("ReceiptId")));
            }
            if (!connState)
            {
                CloseConnection();
            }

            return rec;
        }

        public void Insert(DTO_Receipt rec, DTO_Table tab)
        {
            string qry = "INSERT INTO TABLE_SITTING " +
                "VALUES (@receiptId, @tableId, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@receiptId", rec.Id);
            cmd.Parameters.AddWithValue("@tableId", tab.Id);
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
    }
}