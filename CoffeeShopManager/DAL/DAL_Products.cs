﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Products : DBConnection
    {
        /// <summary>
        /// Gets Id, Name, Type and Price regarding all products; Image and details are shown in the Details tab
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS]";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            ada.Fill(dt);
            if (!connState)
            {
                CloseConnection();
            }

            return dt;
        }

        public DTO_Product GetById(int id)
        {
            DTO_Product dtoPro = null;
            string qry = "SELECT * FROM [PRODUCTS] WHERE Id = @id";
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
                dtoPro = new DTO_Product
                {
                    Id = id,
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                    Detail = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[]
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DTO_Product GetByName(string name)
        {
            DTO_Product dtoPro = null;
            string qry = "SELECT * FROM [PRODUCTS] WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", name);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoPro = new DTO_Product
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = name,
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                    Detail = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[]
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DataTable GetAllProductsOfType(string type)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] WHERE Type = @type";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@type", type);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            ada.Fill(dt);
            if (!connState)
            {
                CloseConnection();
            }

            return dt;
        }

        public DataTable GetAllDrinks()
        {
            return GetAllProductsOfType("Drink");
        }

        public DataTable GetAllFood()
        {
            return GetAllProductsOfType("Food");
        }

        public DataTable GetAllOtherProducts()
        {
            return GetAllProductsOfType("Others");
        }

        public DataTable GetProductsSearchIDFiltered(int id)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetProductsSearchNameFiltered(string nameSubstr)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] " +
                "WHERE Name LIKE '%' + @namesubstr + '%'";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@namesubstr", nameSubstr);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetProductsSearchTypeFiltered(string type)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] " +
                "WHERE Type = @type";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@type", type);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetProductsSearchPriceFiltered(decimal lowerBound, decimal upperBound)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] " +
                "WHERE Price >= @lower AND Price <= @upper";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@lower", lowerBound);
            cmd.Parameters.AddWithValue("@upper", upperBound);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public int GetNextProductId()
        {
            string qry = "SELECT max(Id) FROM [PRODUCTS]";
            int currId = -1;
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                currId = reader.GetInt32(0);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return currId + 1;
        }

        public void InsertWithoutImage(DTO_Product dtoPro)
        {
            string qry = "INSERT INTO [PRODUCTS] (Name, Type, Price, Details) " +
                "VALUES (@name, @type, @price, @details)"; // Chờ image
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Detail);

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

        public void InsertWithImage(DTO_Product dtoPro)
        {
            string qry = "INSERT INTO [PRODUCTS] " +
                "VALUES (@name, @type, @image, @price, @details)"; // Chờ image
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@image", dtoPro.Image);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Detail);

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

        public void Delete(DTO_Product dtoPro)
        {
            string qry = "DELETE FROM [PRODUCTS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);

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

        public void Update(DTO_Product dtoPro)
        {
            string qry = "UPDATE [PRODUCTS] SET " +
                "Name = @name, Type = @type, Image = @image, " +
                "Price = @price, Details = @details " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@image", dtoPro.Image);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Detail);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);

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
