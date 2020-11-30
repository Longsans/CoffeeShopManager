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
    public class DAL_Suppliers : DBConnection
    {

        public DTO_Supplier GetById(string id, int shopId)
        {
            DTO_Supplier sup = null;
            string qry = "SELECT * FROM SUPPLIERS " +
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
                sup = new DTO_Supplier
                {
                    Id = reader["Id"].ToString(),
                    Name = reader["SupplierName"].ToString(),
                    Shop = new DTO_Shop
                    {
                        ID = (int)reader["ShopId"]
                    },
                    Email = reader["EmailAddress"].ToString(),
                    Phone = reader["PhoneNumber"].ToString()
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return sup;
        }

        public DataTable GetAllSuppliers(int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, SupplierName AS Name, " +
                "EmailAddress AS Email, PhoneNumber AS [Phone Number] " +
                "FROM SUPPLIERS " +
                "WHERE ShopId = @shopId";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableById(string id, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, SupplierName AS Name " +
                "EmailAddress AS Email, PhoneNumber AS [Phone Number] " +
                "FROM SUPPLIERS " +
                "WHERE ShopId = @shopId " +
                "AND Id = @id";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);
            ada.SelectCommand.Parameters.AddWithValue("@Id", id);

            ada.Fill(dt);

            return dt;
        }

        public DataTable GetDataTableByName(string name, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id AS ID, SupplierName AS Name " +
                "EmailAddress AS Email, PhoneNumber AS [Phone Number] " +
                "FROM SUPPLIERS " +
                "WHERE ShopId = @shopId " +
                "AND SupplierName LIKE '%' + @name + '%'";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);
            ada.SelectCommand.Parameters.AddWithValue("@name", name);

            ada.Fill(dt);

            return dt;
        }

        public void Insert(DTO_Supplier sup)
        {
            string qry = "INSERT INTO SUPPLIERS " +
                "VALUES (@id, @name, @shopId, @email, @phone)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", sup.Id);
            cmd.Parameters.AddWithValue("@name", sup.Name);
            cmd.Parameters.AddWithValue("@shopId", sup.Shop.ID);
            cmd.Parameters.AddWithValue("@email", sup.Email);
            cmd.Parameters.AddWithValue("@phone", sup.Phone);

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

        public void Delete(DTO_Supplier sup)
        {
            string qry = "DELETE FROM SUPPLIERS " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", sup.Id);
            cmd.Parameters.AddWithValue("@shopId", sup.Shop.ID);

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

        public void Update(DTO_Supplier sup)
        {
            string qry = "UPDATE SUPPLIERS " +
                "SET SupplierName = @name, EmailAddress = @email, " +
                "PhoneNumber = @phone " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", sup.Name);
            cmd.Parameters.AddWithValue("@id", sup.Id);
            cmd.Parameters.AddWithValue("@shopId", sup.Shop.ID);
            cmd.Parameters.AddWithValue("@email", sup.Email);
            cmd.Parameters.AddWithValue("@phone", sup.Phone);

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
