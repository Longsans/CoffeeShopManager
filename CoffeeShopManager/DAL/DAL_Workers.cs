using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Workers : DBConnection
    {
        public DAL_Workers(string connString) : base(connString)
        {

        }

        public DTO_Worker GetById(string id, int shopId)
        {
            DTO_Worker dtoWorker = null;
            string qry = "SELECT * " +
                "FROM [WORKERS] " +
                "WHERE Id = @Id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoWorker = new DTO_Worker
                {
                    Id = id,
                    Firstname = reader.GetString(reader.GetOrdinal("FirstName")),
                    Lastname = reader.GetString(reader.GetOrdinal("LastName")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Position = reader.GetString(reader.GetOrdinal("Position")),
                    Phone = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                    Email = reader.GetString(reader.GetOrdinal("EmailAddress")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[]
                };

                var bdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                dtoWorker.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
                dtoWorker.Account.ID = reader.GetInt32(reader.GetOrdinal("AccountId"));
                dtoWorker.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoWorker;
        }

        public DTO_Worker GetByUsername(string username)
        {
            DTO_Worker dtoWorker = null;
            DAL_UserInfo dalUser = new DAL_UserInfo(this.connectionString);
            string qry = "SELECT *" +
                "FROM [WORKERS] " +
                "WHERE AccountId = @accId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            var user = dalUser.GetByUsername(username);
            if (user != null)
            {
                cmd.Parameters.AddWithValue("@accId", user.ID);

                var connState = (this.conn.State == ConnectionState.Open);
                if (!connState)
                {
                    OpenConnection();
                }
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dtoWorker = new DTO_Worker
                    {
                        Id = reader.GetString(reader.GetOrdinal("Id")),
                        Firstname = reader.GetString(reader.GetOrdinal("FirstName")),
                        Lastname = reader.GetString(reader.GetOrdinal("LastName")),
                        Gender = reader.GetString(reader.GetOrdinal("Gender")),
                        Position = reader.GetString(reader.GetOrdinal("Position")),
                        Phone = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                        Email = reader.GetString(reader.GetOrdinal("EmailAddress")),
                        Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[]
                    };

                    var bdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                    dtoWorker.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
                    dtoWorker.Account.ID = reader.GetInt32(reader.GetOrdinal("AccountId"));
                    dtoWorker.Shop.ID = reader.GetInt32(reader.GetOrdinal("ShopId"));
                }
                if (!connState)
                {
                    CloseConnection();
                }
            }
            
            return dtoWorker;
        }

        public DTO_Worker GetByEmail(string email, int shopId)
        {
            DTO_Worker dtoWorker = null;
            string qry = "SELECT * " +
                "FROM WORKERS " +
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
                dtoWorker = new DTO_Worker
                {
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Firstname = reader.GetString(reader.GetOrdinal("FirstName")),
                    Lastname = reader.GetString(reader.GetOrdinal("LastName")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Position = reader.GetString(reader.GetOrdinal("Position")),
                    Phone = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                    Email = reader.GetString(reader.GetOrdinal("EmailAddress")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[]
                };

                var bdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                dtoWorker.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
                dtoWorker.Account.ID = reader.GetInt32(reader.GetOrdinal("AccountId"));
                dtoWorker.Shop.ID = reader.GetInt32(reader.GetOrdinal("ShopId"));
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoWorker;
        }

        public DTO_User GetUserInfoByUsername(string username)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo(this.connectionString);
            return dalUserInfo.GetByUsername(username);
        }

        public DTO_User GetUserInfoById(string workerId, int shopId)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo(this.connectionString);
            return dalUserInfo.GetById(GetById(workerId, shopId).Account.ID);
        }

        public DataTable GetAllManagerWorkers(int shopId)
        {
            DataTable dtPos = new DataTable();
            string qry = "SELECT MANAGERS.Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
                "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email] " +
                "FROM [WORKERS] INNER JOIN MANAGERS " +
                "ON WORKERS.Id = MANAGERS.Id " +
                "WHERE ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtPos);

            return dtPos;
        }


        /// <summary>
        /// Inserts worker and returns their <c>Id</c>, which mainly serves as a foreign key for tables [EMPLOYEES] and [MANAGERS]
        /// </summary>
        /// <param name="dtoWorker"></param>
        /// <returns>The <c>Id</c> of the worker inserted</returns>
        public string Insert(DTO_Worker dtoWorker)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo(this.connectionString);
            DAL_Shop dalShop = new DAL_Shop(this.connectionString);
            string qry = "INSERT INTO [WORKERS] VALUES " +
                "(@id, @firstName, @lastName, @gender, " +
                "@position, @phoneNumber, @email, " +
                "@birthdate, @accountId, @image, @shopId)";
            bool userInserted = false;
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            
            try
            {
                cmd.Parameters.AddWithValue("@id", dtoWorker.Id);
                cmd.Parameters.AddWithValue("@firstName", dtoWorker.Firstname);
                cmd.Parameters.AddWithValue("@lastName", dtoWorker.Lastname);
                cmd.Parameters.AddWithValue("@gender", dtoWorker.Gender);
                cmd.Parameters.AddWithValue("@position", dtoWorker.Position);
                cmd.Parameters.AddWithValue("@phoneNumber", dtoWorker.Phone);
                cmd.Parameters.AddWithValue("@email", dtoWorker.Email);
                cmd.Parameters.AddWithValue("@birthdate", dtoWorker.Birthdate);
                cmd.Parameters.AddWithValue("@image", dtoWorker.Image);
                cmd.Parameters.AddWithValue("@shopId", dtoWorker.Shop.ID);

                var connState = (this.conn.State == ConnectionState.Open);
                if (!connState)
                {
                    OpenConnection();
                }
                dtoWorker.Account.ID = dalUserInfo.Insert(dtoWorker.Account);
                userInserted = true;
                cmd.Parameters.AddWithValue("@accountId", dtoWorker.Account.ID);

                cmd.ExecuteNonQuery();
                if (!connState)
                {
                    CloseConnection();
                }

                var workerInfo = GetByUsername(dtoWorker.Account.Username);
                return workerInfo.Id;
            }
            catch (Exception e)
            {
                if (userInserted)
                {
                    dalUserInfo.TrueDelete(dtoWorker.Account);
                }
                throw e;
            }
        }

        public void Delete(DTO_Worker dtoWorker)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo(this.connectionString);
            string qry = "DELETE FROM [WORKERS] WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoWorker.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoWorker.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            dalUserInfo.TrueDelete(dtoWorker.Account);
            if (!connState)
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Updates the database where the worker's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="dtoWorkerUpdated">The updated worker</param>
        public void UpdateInfo(DTO_Worker dtoWorkerUpdated)
        {
            string qry = "UPDATE [WORKERS] " +
                "SET FirstName = @fname, LastName = @lname, Gender = @gender, " +
                "Position = @position, PhoneNumber = @phone, " +
                "EmailAddress = @email, Birthdate = @bdate, Image = @image " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@fname", dtoWorkerUpdated.Firstname);
            cmd.Parameters.AddWithValue("@lname", dtoWorkerUpdated.Lastname);
            cmd.Parameters.AddWithValue("@gender", dtoWorkerUpdated.Gender);
            cmd.Parameters.AddWithValue("@position", dtoWorkerUpdated.Position);
            cmd.Parameters.AddWithValue("@phone", dtoWorkerUpdated.Phone);
            cmd.Parameters.AddWithValue("@email", dtoWorkerUpdated.Email);
            cmd.Parameters.AddWithValue("@bdate", dtoWorkerUpdated.Birthdate);
            cmd.Parameters.AddWithValue("@image", dtoWorkerUpdated.Image);
            cmd.Parameters.AddWithValue("@id", dtoWorkerUpdated.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoWorkerUpdated.Shop.ID);

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

        public void UpdateInfoAndAccount(DTO_Worker dtoWorkerUpdated)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo(this.connectionString);

            UpdateInfo(dtoWorkerUpdated);
            dalUserInfo.Update(dtoWorkerUpdated.Account);
        }
    }
}
