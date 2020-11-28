using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Receipts : DBConnection
    {
        public DTO_Receipt GetReceiptById(int id)
        {
            DTO_Receipt rec = null;
            string qry = "SELECT * FROM RECEIPTS WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rec = new DTO_Receipt
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Customer = new DTO_Customer
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("CustomerId"))
                    },
                    DateOfPayMent = reader.GetDateTime(reader.GetOrdinal("DateOfPayment")),
                    Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                    Details = reader.GetString(reader.GetOrdinal("Details")),
                    Items = GetReceiptDetailsListById(id),
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

            return rec;
        }

        public List<DTO_Receipt> GetAllReceiptsByCustomerId(int customerId)
        {
            List<DTO_Receipt> recList = new List<DTO_Receipt>();
            string qry = "SELECT * FROM RECEIPTS WHERE CustomerId = @cusId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@cusId", customerId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var rec = new DTO_Receipt
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Customer = new DTO_Customer
                    {
                        Id = customerId
                    },
                    DateOfPayMent = reader.GetDateTime(reader.GetOrdinal("DateOfPayment")),
                    Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                    Shop = new DTO_Shop
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ShopId"))
                    }
                };
                if (!reader.IsDBNull(reader.GetOrdinal("Details")))
                {
                    rec.Details = reader.GetString(reader.GetOrdinal("Details"));
                }
                recList.Add(rec);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return recList;
        }

        public List<DTO_ReceiptDetails> GetReceiptDetailsListById(int receiptId)
        {
            List<DTO_ReceiptDetails> detailsList = new List<DTO_ReceiptDetails>();
            string qry = "SELECT * FROM RECEIPT_DETAILS WHERE ReceiptId = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", receiptId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var recDetails = new DTO_ReceiptDetails
                {
                    Product = new DTO_Product
                    {
                        Id = reader.GetString(reader.GetOrdinal("ProductId"))
                    },
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    TotalPrice = reader.GetDecimal(reader.GetOrdinal("TotalPrice"))
                };
                detailsList.Add(recDetails);
            }
            if (!connState)
            {
                CloseConnection();
            }

            if (detailsList.Count > 0) return detailsList;
            return null;
        }

        public DataTable GetAllReceipts(int shopId)
        {
            DataTable dtReceipts = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], DateOfPayMent AS [Date of Payment], Total " +
                "FROM RECEIPTS " +
                "INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE RECEIPTS.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtReceipts);

            return dtReceipts;
        }
        
        public DataTable GetReceiptDetailsGridViewByReceiptId(int receiptId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT ProductId AS ID, Name, Quantity, TotalPrice AS [Total Price] " +
                "FROM RECEIPT_DETAILS INNER JOIN PRODUCTS " +
                "ON RECEIPT_DETAILS.ProductId = PRODUCTS.Id " +
                "AND RECEIPT_DETAILS.ShopId = PRODUCTS.ShopId " +
                "WHERE ReceiptId = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", receiptId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchIdFiltered(int id)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], DateOfPayment AS [Date of Payment], Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "WHERE RECEIPTS.Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchCustomersIdFiltered(int cusId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], DateOfPayment AS [Date of Payment], Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE CustomerId = @cusId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@cusId", cusId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchDateOfPaymentFiltered(DateTime dop)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], DateOfPayment AS [Date of Payment], Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE datediff(day, DateOfPayment, @dop) = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@dop", dop);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DTO_Table GetTableOfReceipt(int receiptId)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            DTO_Table tab = null;
            tab = dalTabSitting.GetTableOfReceipt(receiptId);

            return tab;
        }

        public void InsertTakeAwayReceipt(DTO_Receipt rec)
        {
            string qry = "INSERT INTO RECEIPTS " +
                "VALUES (@cusId, @dateofpayment, @total, @details, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@cusId", rec.Customer.Id);
            cmd.Parameters.AddWithValue("@dateofpayment", rec.DateOfPayMent);
            cmd.Parameters.AddWithValue("@total", rec.Total);
            cmd.Parameters.AddWithValue("@details", rec.Details);
            cmd.Parameters.AddWithValue("@shopId", rec.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            InsertReceiptDetails(rec);
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void InsertSittingReceipt(DTO_Receipt rec, DTO_Table tab)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            InsertTakeAwayReceipt(rec);
            dalTabSitting.Insert(rec, tab);
        }

        private void InsertReceiptDetails(DTO_Receipt rec)
        {
            foreach (var item in rec.Items)
            {
                string qry = "INSERT INTO RECEIPT_DETAILS " +
                "VALUES (@recId, @proId, @shopId, @qty, @totalPrice)";
                SqlCommand cmd = new SqlCommand(qry, this.conn);
                cmd.Parameters.AddWithValue("@recId", rec.Id);
                cmd.Parameters.AddWithValue("@proId", item.Product.Id);
                cmd.Parameters.AddWithValue("@shopId", rec.Shop.ID);
                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@totalPrice", item.TotalPrice);

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

        public void DeleteAllReceiptsOfCustomer(DTO_Customer cus)
        {
            var recList = GetAllReceiptsByCustomerId(cus.Id);
            
            foreach (var rec in recList)
            {
                DeleteReceipt(rec);
            }
        }

        public void DeleteReceipt(DTO_Receipt rec)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            string qry = "DELETE FROM RECEIPTS WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", rec.Id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalTabSitting.DeleteAllSittingsByReceipt(rec);
            DeleteReceiptDetails(rec);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        private void DeleteReceiptDetails(DTO_Receipt rec)
        {
            string qry = "DELETE FROM RECEIPT_DETAILS WHERE ReceiptId = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", rec.Id);

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
