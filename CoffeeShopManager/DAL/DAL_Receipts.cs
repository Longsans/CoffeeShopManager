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
        public DTO_Receipt GetReceiptById(int id, int shopId)
        {
            DTO_Receipt rec = null;
            string qry = "SELECT * FROM RECEIPTS " +
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
                rec = new DTO_Receipt
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Customer = new DTO_Customer
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("CustomerId"))
                    },
                    DateOfPayMent = reader.GetDateTime(reader.GetOrdinal("DateOfPayment")),
                    Discount = (decimal)reader["Discount"],
                    Total = (decimal)reader["Total"],
                    Details = reader.GetString(reader.GetOrdinal("Details")),
                    Items = GetReceiptDetailsListById(id, shopId),
                    Shop = new DTO_Shop
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ShopId"))
                    }
                };
                if (!reader.IsDBNull(reader.GetOrdinal("EmployeeId")))
                {
                    rec.Employee = new DTO_Employee
                    {
                        Id = reader["EmployeeId"].ToString()
                    };
                }
            }
            if (!connState)
            {
                CloseConnection();
            }

            return rec;
        }

        public List<DTO_Receipt> GetAllReceiptsByCustomerId(int customerId, int shopId)
        {
            List<DTO_Receipt> recList = new List<DTO_Receipt>();
            string qry = "SELECT * FROM RECEIPTS " +
                "WHERE CustomerId = @cusId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@cusId", customerId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

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
                    Discount = (decimal)reader["Discount"],
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
                if (!reader.IsDBNull(reader.GetOrdinal("EmployeeId")))
                {
                    rec.Employee = new DTO_Employee
                    {
                        Id = reader["EmployeeId"].ToString()
                    };
                }
                recList.Add(rec);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return recList;
        }

        public List<DTO_ReceiptDetails> GetReceiptDetailsListById(int receiptId, int shopId)
        {
            List<DTO_ReceiptDetails> detailsList = new List<DTO_ReceiptDetails>();
            string qry = "SELECT * FROM RECEIPT_DETAILS " +
                "INNER JOIN PRODUCTS " +
                "ON RECEIPT_DETAILS.ProductId = PRODUCTS.Id " +
                "AND RECEIPT_DETAILS.ShopId = PRODUCTS.ShopId " +
                "WHERE ReceiptId = @id AND RECEIPT_DETAILS.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", receiptId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

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
                        Id = reader.GetString(reader.GetOrdinal("ProductId")),
                        Name = reader["Name"].ToString(),
                        Shop = new DTO_Shop
                        {
                            ID = (int)reader["ShopId"]
                        }
                    },
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    TotalPrice = decimal.Round((decimal)reader["TotalPrice"], 2, MidpointRounding.AwayFromZero)
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
                "LastName AS [Customer's Last Name], CONVERT(varchar(11), DateOfPayMent, 103) AS [Date of Payment], " +
                "EmployeeId AS [Employee ID], cast(Total as decimal(10, 2)) AS Total " +
                "FROM RECEIPTS " +
                "INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE RECEIPTS.ShopId = @shopId " +
                "ORDER BY RECEIPTS.Id ASC";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtReceipts);

            return dtReceipts;
        }
        
        public DataTable GetReceiptDetailsGridViewByReceiptId(int receiptId, int shopId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT ProductId AS ID, Name, Quantity, cast(TotalPrice as decimal(10, 2)) AS [Total Price] " +
                "FROM RECEIPT_DETAILS INNER JOIN PRODUCTS " +
                "ON RECEIPT_DETAILS.ProductId = PRODUCTS.Id " +
                "AND RECEIPT_DETAILS.ShopId = PRODUCTS.ShopId " +
                "WHERE ReceiptId = @id AND RECEIPT_DETAILS.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", receiptId);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchIdFiltered(int id, int shopId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], CONVERT(varchar(11), DateOfPayMent, 103) AS [Date of Payment], " +
                "EmployeeId AS [Employee ID], cast(Total as decimal(10, 2)) AS Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE RECEIPTS.Id = @id AND RECEIPTS.ShopId = @shopId " +
                "ORDER BY RECEIPTS.Id ASC";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchCustomersIdFiltered(int cusId, int shopId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], CONVERT(varchar(11), DateOfPayMent, 103) AS [Date of Payment], " +
                "EmployeeId AS [Employee ID], cast(Total as decimal(10, 2)) AS Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE CustomerId = @cusId AND RECEIPTS.ShopId = @shopId " +
                "ORDER BY RECEIPTS.Id ASC";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@cusId", cusId);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchDateOfPaymentFiltered(DateTime dop, int shopId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], CONVERT(varchar(11), DateOfPayMent, 103) AS [Date of Payment], " +
                "EmployeeId AS [Employee ID], cast(Total as decimal(10, 2)) AS Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE datediff(day, DateOfPayment, @dop) = 0 " +
                "AND RECEIPTS.ShopId = @shopId " +
                "ORDER BY RECEIPTS.Id ASC";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@dop", dop);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DataTable GetReceiptSearchEmployeesIdFiltered(string empId, int shopId)
        {
            DataTable dtRecDetails = new DataTable();
            string qry = "SELECT RECEIPTS.Id AS ID, CustomerId AS [Customer ID], FirstName AS [Customer's First Name], " +
                "LastName AS [Customer's Last Name], CONVERT(varchar(11), DateOfPayMent, 103) AS [Date of Payment], " +
                "EmployeeId AS [Employee ID], cast(Total as decimal(10, 2)) AS Total " +
                "FROM RECEIPTS INNER JOIN CUSTOMERS " +
                "ON RECEIPTS.CustomerId = CUSTOMERS.Id " +
                "AND RECEIPTS.ShopId = CUSTOMERS.ShopId " +
                "WHERE EmployeeId = @empId AND RECEIPTS.ShopId = @shopId " +
                "ORDER BY RECEIPTS.Id ASC";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@empId", empId);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtRecDetails);

            return dtRecDetails;
        }

        public DTO_Table GetTableOfReceipt(int receiptId, int shopId)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            DTO_Table tab = null;
            tab = dalTabSitting.GetTableOfReceipt(receiptId, shopId);

            return tab;
        }

        public void InsertTakeAwayReceipt(DTO_Receipt rec)
        {
            string compoundQry = "INSERT INTO RECEIPTS (CustomerId, EmployeeId, DateOfPayment, Discount, Total, Details, ShopId)" +
                "VALUES (@cusId, @empId, @dateofpayment, @discount, @total, @details, @shopId); " +
                "SELECT max(Id) " +
                "FROM RECEIPTS " +
                "WHERE ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(compoundQry, this.conn);
            cmd.Parameters.AddWithValue("@cusId", rec.Customer.Id);
            cmd.Parameters.AddWithValue("@empId", rec.Employee.Id);
            cmd.Parameters.AddWithValue("@dateofpayment", rec.DateOfPayMent);
            cmd.Parameters.AddWithValue("@discount", rec.Discount);
            cmd.Parameters.AddWithValue("@total", rec.Total);
            cmd.Parameters.AddWithValue("@details", rec.Details);
            cmd.Parameters.AddWithValue("@shopId", rec.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            rec.Id = Convert.ToInt32(cmd.ExecuteScalar());
            InsertReceiptDetails(rec);
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void InsertSittingReceipt(DTO_Receipt rec, DTO_Table tab)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            DTO_TableSitting tabSit = new DTO_TableSitting
            {
                Receipt = rec,
                Table = tab,
                Sitting = true
            };
            InsertTakeAwayReceipt(rec);
            dalTabSitting.Insert(tabSit);
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
            var recList = GetAllReceiptsByCustomerId(cus.Id, cus.Shop.ID);
            
            foreach (var rec in recList)
            {
                DeleteReceipt(rec);
            }
        }

        public void DeleteReceipt(DTO_Receipt rec)
        {
            DAL_TableSitting dalTabSitting = new DAL_TableSitting();
            string qry = "DELETE FROM RECEIPTS " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", rec.Id);
            cmd.Parameters.AddWithValue("@shopId", rec.Shop.ID);

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
            string qry = "DELETE FROM RECEIPT_DETAILS " +
                "WHERE ReceiptId = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", rec.Id);
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
