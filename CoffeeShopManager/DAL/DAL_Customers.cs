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
    public class DAL_Customers : DBConnection
    {
        public DataTable GetAllCustomers(int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
                "EmailAddress AS Email, CONVERT(varchar(11), Birthdate, 103) AS Birthdate " +
                "FROM CUSTOMERS " +
                "WHERE ShopId = @shopId";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DTO_Customer GetCustomerById(int id)
        {
            DTO_Customer cus = null;
            string qry = "SELECT Id AS ID, FirstName, LastName, " +
                "EmailAddress, Birthdate " +
                "FROM CUSTOMERS " +
                "WHERE Id = @id";
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
                cus = new DTO_Customer
                {
                    Id = id,
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("EmailAddress")),
                    Birthdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"))
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return cus;
        }

        public DTO_Customer GetCustomerByEmail(string email, int shopId)
        {
            DTO_Customer cus = null;
            string qry = "SELECT Id AS ID, FirstName, LastName, " +
                "EmailAddress, Birthdate " +
                "FROM CUSTOMERS " +
                "WHERE EmailAddress = @email AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cus = new DTO_Customer
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = email,
                    Birthdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"))
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return cus;
        }

        public DataTable GetCustomerSearchIDFiltered(int id)
        {
            DataTable dtCus = new DataTable();
            string qry = "SELECT Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
                "EmailAddress AS Email, CONVERT(varchar(11), Birthdate, 103) AS Birthdate " +
                "FROM CUSTOMERS " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtCus);

            return dtCus;
        }

        public DataTable GetCustomersSearchNameFiltered(string name, int shopId)
        {
            DataTable dtCus = new DataTable();
            string qry = "SELECT Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
                "EmailAddress AS Email, CONVERT(varchar(11), Birthdate, 103) AS Birthdate " +
                "FROM CUSTOMERS " +
                "WHERE CONCAT(FirstName, ' ', LastName) LIKE '%' + @name + '%' " +
                "AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtCus);

            return dtCus;
        }

        public DataTable GetCustomerSearchEmailFiltered(string email, int shopId)
        {
            DataTable dtCus = new DataTable();
            string qry = "SELECT Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
                "EmailAddress AS Email, CONVERT(varchar(11), Birthdate, 103) AS Birthdate " +
                "FROM CUSTOMERS " +
                "WHERE EmailAddress = @email AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtCus);

            return dtCus;
        }

        public void Insert(DTO_Customer cus)
        {
            string qry = "INSERT INTO CUSTOMERS " +
                "VALUES (@fname, @lname, @email, @bdate, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@fname", cus.FirstName);
            cmd.Parameters.AddWithValue("@lname", cus.LastName);
            cmd.Parameters.AddWithValue("@email", cus.Email);
            cmd.Parameters.AddWithValue("@bdate", cus.Birthdate);
            cmd.Parameters.AddWithValue("@shopId", cus.ShopID);

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

        public void Delete(DTO_Customer cus)
        {
            DAL_Receipts dalRec = new DAL_Receipts();
            string qry = "DELETE FROM CUSTOMERS WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", cus.Id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalRec.DeleteAllReceiptsOfCustomer(cus);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void Update(DTO_Customer cus)
        {
            string qry = "UPDATE CUSTOMERS " +
                "SET EmailAddress = @email, " +
                "Birthdate = @bdate " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", cus.Email);
            cmd.Parameters.AddWithValue("@bdate", cus.Birthdate);
            cmd.Parameters.AddWithValue("@id", cus.Id);

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
