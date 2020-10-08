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

        // Thêm, xóa, sửa...
    }
}
