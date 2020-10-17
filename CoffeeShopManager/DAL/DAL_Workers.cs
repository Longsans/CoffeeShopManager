using System;
using System.Collections.Generic;
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
        public DTO_Worker GetInfoById(int id)
        {
            DTO_Worker dtoWorker = null;
            string qry = "SELECT Id, FirstName, LastName, " +
                "Gender, Position, PhoneNumber, " +
                "EmailAddress, Birthdate, Image " +
                "FROM [WORKERS] WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

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
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Firstname = reader.GetString(reader.GetOrdinal("FirstName")),
                    Lastname = reader.GetString(reader.GetOrdinal("LastName")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Position = reader.GetString(reader.GetOrdinal("Position")),
                    Phone = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[]
                };
                dtoWorker.Account.Email = reader.GetString(reader.GetOrdinal("EmailAddress"));

                var bdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                dtoWorker.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoWorker;
        }

        public DTO_Worker GetInfoByEmail(string email)
        {
            DTO_Worker dtoWorker = null;
            string qry = "SELECT Id FROM [WORKERS] WHERE EmailAddress = @email";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoWorker = GetInfoById(reader.GetInt32(reader.GetOrdinal("Id")));
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoWorker;
        }

        public DTO_User GetUserInfoByEmail(string email)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo();
            return dalUserInfo.GetByEmail(email);
        }

        public DTO_User GetUserInfoById(int workerId)
        {
            return GetUserInfoByEmail(GetInfoById(workerId).Account.Email);
        }

        public DataTable GetAllManagerWorkers()
        {
            DataTable dtPos = new DataTable();
            string qry = "SELECT Id, FirstName, LastName, " +
                "Gender, Position, PhoneNumber, EmailAddress" +
                " FROM [WORKERS] WHERE Position = @position";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@position", "Manager");
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtPos);

            return dtPos;
        }

        public DataTable GetAllEmployeeWorkers()
        {
            DataTable dtPos = new DataTable();
            string qry = "SELECT Id, FirstName, LastName, " +
                "Gender, Position, PhoneNumber, EmailAddress " +
                " FROM [WORKERS] WHERE Position <> @position";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@position", "Manager");
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtPos);

            return dtPos;
        }

        /// <summary>
        /// Inserts worker and returns their <c>Id</c>, which mainly serves as a foreign key for tables [EMPLOYEES] and [MANAGERS]
        /// </summary>
        /// <param name="dtoWorker"></param>
        /// <returns>The <c>Id</c> of the worker inserted</returns>
        public int Insert(DTO_Worker dtoWorker)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo();
            string qry = "INSERT INTO [WORKERS] VALUES " +
                "(@firstName, @lastName, @gender, " +
                "@position, @phoneNumber, @email, " +
                "@birthdate, @accountId, @image)";
            bool userInserted = false;
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            
            try
            {
                cmd.Parameters.AddWithValue("@firstName", dtoWorker.Firstname);
                cmd.Parameters.AddWithValue("@lastName", dtoWorker.Lastname);
                cmd.Parameters.AddWithValue("@gender", dtoWorker.Gender);
                cmd.Parameters.AddWithValue("@position", dtoWorker.Position);
                cmd.Parameters.AddWithValue("@phoneNumber", dtoWorker.Phone);
                cmd.Parameters.AddWithValue("@email", dtoWorker.Account.Email);
                cmd.Parameters.AddWithValue("@birthdate", dtoWorker.Birthdate);
                cmd.Parameters.AddWithValue("@image", dtoWorker.Image);

                var connState = (this.conn.State == ConnectionState.Open);
                if (!connState)
                {
                    OpenConnection();
                }
                dalUserInfo.Insert(dtoWorker.Account);
                userInserted = true;
                int accountId = dalUserInfo.GetByEmail(dtoWorker.Account.Email).ID;
                cmd.Parameters.AddWithValue("@accountId", accountId);

                cmd.ExecuteNonQuery();
                if (!connState)
                {
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                if (userInserted)
                {
                    dalUserInfo.Delete(dtoWorker.Account);
                }
                throw e;
            }

            var workerInfo = GetInfoByEmail(dtoWorker.Account.Email);
            if (workerInfo != null) return workerInfo.Id;
            return -1;
        }

        public void Delete(DTO_Worker dtoWorker)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo();
            string qry = "DELETE FROM [WORKERS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoWorker.Id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalUserInfo.Delete(dtoWorker.Account);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Updates the database where the worker's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="dtoWorkerUpdated">The updated worker</param>
        public void Update(DTO_Worker dtoWorkerUpdated)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo();
            string qry = "UPDATE [WORKERS] " +
                "SET FirstName = @fname, LastName = @lname, Gender = @gender, " +
                "Position = @position, PhoneNumber = @phone, EmailAddress = @email, " +
                "Birthdate = @bdate, Image = @image " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@fname", dtoWorkerUpdated.Firstname);
            cmd.Parameters.AddWithValue("@lname", dtoWorkerUpdated.Lastname);
            cmd.Parameters.AddWithValue("@gender", dtoWorkerUpdated.Gender);
            cmd.Parameters.AddWithValue("@position", dtoWorkerUpdated.Position);
            cmd.Parameters.AddWithValue("@phone", dtoWorkerUpdated.Phone);
            cmd.Parameters.AddWithValue("@email", dtoWorkerUpdated.Account.Email);
            cmd.Parameters.AddWithValue("@bdate", dtoWorkerUpdated.Birthdate);
            cmd.Parameters.AddWithValue("@image", dtoWorkerUpdated.Image);
            cmd.Parameters.AddWithValue("@id", dtoWorkerUpdated.Id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalUserInfo.Update(dtoWorkerUpdated.Account);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public int GetNextWorkerId()
        {
            string qry = "SELECT max(Id) FROM [WORKERS]";
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            int currId = -1;
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
    }
}
