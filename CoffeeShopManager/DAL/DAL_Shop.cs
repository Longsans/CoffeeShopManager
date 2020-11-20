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
    public class DAL_Shop : DBConnection
    {
        public DTO_Shop GetShopById(int id)
        {
            DTO_Shop shop = null;
            string qry = "SELECT * FROM SHOP " +
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
                shop = new DTO_Shop
                {
                    ID = id,
                    ShopName = reader.GetString(reader.GetOrdinal("ShopName")),
                    AuthCode = reader.GetString(reader.GetOrdinal("ShopAuthCode"))
                };

                if (!reader.IsDBNull(reader.GetOrdinal("ShopAddress")))
                {
                    shop.ShopAddress = reader.GetString(reader.GetOrdinal("ShopAddress"));
                }
                if (!reader.IsDBNull(reader.GetOrdinal("PhoneNumber")))
                {
                    shop.Phone = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                }
            }
            if (!connState)
            {
                CloseConnection();
            }

            return shop;
        }

        public int Insert(DTO_Shop shop)
        {
            int shopId;
            string qry = "INSERT INTO SHOP (ShopName, ShopAuthCode) " +
                "VALUES (@name, @authcode); " +
                "SELECT Id FROM SHOP " +
                "WHERE Id = SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", shop.ShopName);
            cmd.Parameters.AddWithValue("@authcode", shop.AuthCode);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            shopId = (int)cmd.ExecuteScalar();
            if (!connState)
            {
                CloseConnection();
            }

            return shopId;
        }

        public void Delete(DTO_Shop shop)
        {
            string qry = "DELETE FROM SHOP " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", shop.ID);

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

        public void Update(DTO_Shop shop)
        {
            string qry = "UPDATE SHOP " +
                "SET ShopName = @name, ShopAddress = @address, PhoneNumber = @phone, ShopAuthCode = @authcode " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", shop.ShopName);
            cmd.Parameters.AddWithValue("@address", shop.ShopAddress);
            cmd.Parameters.AddWithValue("@phone", shop.Phone);
            cmd.Parameters.AddWithValue("@authcode", shop.AuthCode);
            cmd.Parameters.AddWithValue("@id", shop.ID);

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

        public int GetNextShopId()
        {
            int nextId;
            string qry = "SELECT max(Id) " +
                "FROM SHOP";
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            nextId = (int)(cmd.ExecuteScalar());
            if (!connState)
            {
                CloseConnection();
            }

            return nextId + 1;
        }
    }
}
