using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            string[] bdate;
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

                bdate = reader.GetString(reader.GetOrdinal("Birthdate")).Split('/');
                dtoWorker.Birthdate = new DateTime(Int32.Parse(bdate[0]), Int32.Parse(bdate[1]), Int32.Parse(bdate[2]));
            }
            CloseConnection();

            return dtoWorker;
        }

        public DTO_User GetUserInfoById(int id)
        {
            DTO_User dtoUser = null;
            string qry = "SELECT [USERS].Id FROM [USERS] " +
                "INNER JOIN [WORKERS]" +
                "ON [WORKERS].EmailAddress = [USERS].EmailAddress" +
                "WHERE [WORKERS].Id = @Id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

            OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                DAL_UserInfo uInfo = new DAL_UserInfo();
                dtoUser = uInfo.GetById(reader.GetInt32(reader.GetOrdinal("Id")));
            }
            CloseConnection();

            return dtoUser;
        }

        // Thêm, xóa, sửa...
    }
}
