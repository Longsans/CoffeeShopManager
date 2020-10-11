using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
                "EmailAddress, Birthdate " +
                "FROM [WORKERS] WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

            OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoWorker.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                dtoWorker.Firstname = reader.GetString(reader.GetOrdinal("FirstName"));
                dtoWorker.Lastname = reader.GetString(reader.GetOrdinal("LastName"));
                dtoWorker.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                dtoWorker.Position = reader.GetString(reader.GetOrdinal("Position"));
                dtoWorker.Phone = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                dtoWorker.Account.Email = reader.GetString(reader.GetOrdinal("EmailAddress"));

                var bdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                dtoWorker.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
            }
            CloseConnection();

            return dtoWorker;
        }

        private DTO_Worker GetInfoByEmail(string email)
        {
            DTO_Worker dtoWorker = null;
            string qry = "SELECT * FROM [WORKERS] WHERE EmailAddress = @email";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);

            OpenConnection();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoWorker = GetInfoById(reader.GetInt32(reader.GetOrdinal("Id")));
            }
            CloseConnection();

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
            return GetAllWorkerOfPosition("Manager");
        }

        public DataTable GetAllEmployeeWorkers()
        {
            return GetAllWorkerOfPosition("Employee");
        }

        private DataTable GetAllWorkerOfPosition(string position)
        {
            DataTable dtPos = new DataTable();
            string qry = "SELECT * FROM [WORKERS] WHERE Position = @position";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@position", position);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            OpenConnection();
            ada.Fill(dtPos);
            CloseConnection();

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
                "@birthdate, @accountId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@firstName", dtoWorker.Firstname);
            cmd.Parameters.AddWithValue("@lastName", dtoWorker.Lastname);
            cmd.Parameters.AddWithValue("@gender", dtoWorker.Gender);
            cmd.Parameters.AddWithValue("@position", dtoWorker.Position);
            cmd.Parameters.AddWithValue("@phoneNumber", dtoWorker.Phone);
            cmd.Parameters.AddWithValue("@email", dtoWorker.Account.Email);
            cmd.Parameters.AddWithValue("@birthdate", dtoWorker.Birthdate);

            dalUserInfo.Insert(dtoWorker.Account);
            int accountId = dalUserInfo.GetByEmail(dtoWorker.Account.Email).ID;
            cmd.Parameters.AddWithValue("@accountId", accountId);

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();

            return GetInfoByEmail(dtoWorker.Account.Email).Id;
        }

        public void Delete(DTO_Worker dtoWorker)
        {
            DAL_UserInfo dalUserInfo = new DAL_UserInfo();
            string qry = "DELETE FROM [WORKERS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoWorker.Id);

            dalUserInfo.Delete(dtoWorker.Account);
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
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
                "Birthdate = @bdate " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@fname", dtoWorkerUpdated.Firstname);
            cmd.Parameters.AddWithValue("@lname", dtoWorkerUpdated.Lastname);
            cmd.Parameters.AddWithValue("@gender", dtoWorkerUpdated.Gender);
            cmd.Parameters.AddWithValue("@position", dtoWorkerUpdated.Position);
            cmd.Parameters.AddWithValue("@phone", dtoWorkerUpdated.Phone);
            cmd.Parameters.AddWithValue("@email", dtoWorkerUpdated.Account.Email);
            cmd.Parameters.AddWithValue("@bdate", dtoWorkerUpdated.Birthdate);
            cmd.Parameters.AddWithValue("@id", dtoWorkerUpdated.Id);

            dalUserInfo.Update(dtoWorkerUpdated.Account);
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
