using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Manager : DBConnection
    {
        public DTO_Manager GetById(int id)
        {
            DTO_Manager dtoMan = null;
            DAL_Workers dalWorker = new DAL_Workers();
            DTO_Worker dtoWrk = dalWorker.GetInfoById(id);
            dtoMan = new DTO_Manager(dtoWrk);

            string qry = "SELECT [USERS].Id FROM [USERS] " +
                "INNER JOIN [MANAGERS] " +
                "ON [MANAGERS].Id = [USERS].ManagerId " +
                "WHERE [MANAGERS].Id = @Id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

            OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var wr = dalWorker.GetInfoById(reader.GetInt32(reader.GetOrdinal("Id")));
                var emp = new DTO_Employee(wr);
                dtoMan.ls.Add(emp);
            }

            return dtoMan;
        }

        public DTO_User GetUserInfoById(int id)
        {
            DAL_Workers dalWr = new DAL_Workers();
            return dalWr.GetUserInfoById(id);
        }

        // Còn các hàm GetEmployeeList(), thêm, xóa, sửa,...
    }
}
