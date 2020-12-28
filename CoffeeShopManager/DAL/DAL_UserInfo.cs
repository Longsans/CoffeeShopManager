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
        public DAL_UserInfo(string connString) : base(connString)
        {

        }

        public DTO_User GetById(int id)
        {
            DTO_User dtoUser = null;
            string qry = "SELECT * FROM [USERS] WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoUser = new DTO_User
                {
                    ID = id,
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    PassWord = reader.GetString(reader.GetOrdinal("Password")),
                    Deleted = Convert.ToBoolean(reader["Deleted"])
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoUser;
        }

        public DTO_User GetByUsername(string username)
        {
            DTO_User dtoUser = null;
            string qry = "SELECT * FROM [USERS] WHERE Username = @username";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@username", username);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoUser = new DTO_User
                {
                    ID = reader.GetInt32(reader.GetOrdinal("Id")),
                    Username = username,
                    PassWord = reader.GetString(reader.GetOrdinal("Password")),
                    Deleted = Convert.ToBoolean(reader["Deleted"])
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoUser;
        }

        public int Insert(DTO_User dtoUser)
        {
            string qry = "INSERT INTO [USERS] " +
                "VALUES (@username, @password, @del)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@username", dtoUser.Username);
            cmd.Parameters.AddWithValue("@password", dtoUser.PassWord);
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

            var userInfo = GetByUsername(dtoUser.Username);
            return userInfo.ID;
        }

        public void FalseDelete(DTO_User dtoUser)
        {
            string qry = "UPDATE [USERS] " +
                "SET Deleted = 1 " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoUser.ID);

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

        public void TrueDelete(DTO_User dtoUser)
        {
            string qry = "DELETE FROM [USERS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoUser.ID);

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

        public void RestoreDeletedUser(DTO_User dtoUser)
        {
            string qry = "UPDATE [USERS] " +
                "SET Deleted = 0 " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoUser.ID);

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

        /// <summary>
        /// Updates the database where the user's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="dtoUserUpdated">The updated user</param>
        public void Update(DTO_User dtoUserUpdated)
        {
            string qry = "UPDATE [USERS] " +
                "SET Username = @username, Password = @passwd " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@username", dtoUserUpdated.Username);
            cmd.Parameters.AddWithValue("@passwd", dtoUserUpdated.PassWord);
            cmd.Parameters.AddWithValue("@id", dtoUserUpdated.ID);

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
