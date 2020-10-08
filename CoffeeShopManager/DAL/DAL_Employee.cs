using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Runtime.InteropServices;
using System.Globalization;

namespace DAL
{
    public class DAL_Employee : DBConnection
    {
        public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            DAL_Workers dalWr = new DAL_Workers();
            string qry = "SELECT * FROM [EMPLOYEES]";

            return dt;
        }

        public DTO_Employee GetById(int id)
        {
            DTO_Employee emp = null;
            //

            return emp;
        }

        public bool Insert(DTO_Employee emp)
        {
            try
            {
                var dtinfo = new DataTable();
                string qry = "SELECT * FROM [EMPLOYEES]";
                var adapter = new SqlDataAdapter(qry, this.conn);
                DataRow row;

                OpenConnection();
                adapter.Fill(dtinfo);
                new SqlCommandBuilder(adapter);
                row = dtinfo.NewRow();
                //

                CloseConnection();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var dtinfo = new DataTable();
                string qry = "SELECT * FROM [EMPLOYEES]";
                var adapter = new SqlDataAdapter(qry, this.conn);
                DataRow row;

                OpenConnection();
                adapter.Fill(dtinfo);
                new SqlCommandBuilder(adapter);
                for (int i = 0; i < dtinfo.Rows.Count; ++i)
                {
                    if ((int)(dtinfo.Rows[i]["Id"]) == id)
                    {
                        dtinfo.Rows[i].Delete();
                    }
                }
                adapter.Update(dtinfo);
                CloseConnection();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(DTO_Employee empUpdated)
        {
            var dtinfo = this.GetAllEmployees();
            try
            {
                var row = dtinfo.Rows.Find(empUpdated);

                OpenConnection();
                //

                CloseConnection();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
