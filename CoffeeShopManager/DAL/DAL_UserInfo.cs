using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_UserInfo : DBConnection
    {
        public DTO_User GetById(int id)
        {
            DTO_User dtoUser = null;
            string qry = "SELECT * FROM [USERS] WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

            OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoUser.ID = reader.GetInt32(reader.GetOrdinal("Id"));
                dtoUser.Email = reader.GetString(reader.GetOrdinal("EmailAddress"));
                dtoUser.PassWord = reader.GetString(reader.GetOrdinal("Password"));
            }
            CloseConnection();

            return dtoUser;
        }

        public DTO_User GetByEmail(string email)
        {
            DTO_User dtoUser = null;
            string qry = "SELECT * FROM [USERS] WHERE EmailAddress = @email";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);

            OpenConnection();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoUser = GetById(reader.GetInt32(reader.GetOrdinal("Id")));
            }
            CloseConnection();

            return dtoUser;
        }

        public void Insert(DTO_User dtoUser)
        {
            string qry = "INSERT INTO [USERS] VALUES (@email, @password)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", dtoUser.Email);
            cmd.Parameters.AddWithValue("@password", dtoUser.PassWord);

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void Delete(DTO_User dtoUser)
        {
            string qry = "DELETE FROM [USERS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoUser.ID);

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        /// <summary>
        /// Updates the database where the user's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="dtoUserUpdated">The updated user</param>
        public void Update(DTO_User dtoUserUpdated)
        {
            string qry = "UPDATE [USERS] " +
                "SET EmailAddress = @email, Password = @passwd " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", dtoUserUpdated.Email);
            cmd.Parameters.AddWithValue("@passwd", dtoUserUpdated.PassWord);
            cmd.Parameters.AddWithValue("@id", dtoUserUpdated.ID);

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
