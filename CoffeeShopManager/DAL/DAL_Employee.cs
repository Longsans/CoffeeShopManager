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
            DataTable dtEmp = new DataTable();
            DAL_Workers dalWr = new DAL_Workers();
            string qry = "SELECT * FROM [EMPLOYEES]";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            
            OpenConnection();
            ada.Fill(dtEmp);
            CloseConnection();

            var dtWorkers = dalWr.GetAllEmployeeWorkers();
            var dtMerged = dtWorkers.Clone();
            for (int i = 1; i < dtEmp.Columns.Count; ++i)
            {
                dtMerged.Columns.Add(dtEmp.Columns[i]);
            }

            var workerTab = dtWorkers.AsEnumerable();
            var empTab = dtEmp.AsEnumerable();
            var mergedRows = workerTab.Zip(empTab, (r1, r2) => r1.ItemArray.Concat(r2.ItemArray).ToArray());
            foreach (object[] row in mergedRows)
            {
                dtMerged.Rows.Add(row);
            }

            return dtMerged;
        }

        /// <summary>Gets the employee with the specified <c>Id</c> and only the <c>Id</c> of the <c>Manager</c> property; returns <returns>null</returns> if no employee with such <c>Id</c> exists</summary>
        public DTO_Employee GetEmployeeInfoAndManagerId(int id) // Only gets the manager's id, which is already included in [EMPLOYEES] table
        {
            
            DTO_Employee emp = null;
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "SELECT * FROM [EMPLOYEES] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);

            OpenConnection();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                emp = new DTO_Employee(dalWorkers.GetInfoById(reader.GetInt32(reader.GetOrdinal("Id"))));
                emp.Address = reader.GetString(reader.GetOrdinal("Address"));

                var dateofjoin = reader.GetDateTime(reader.GetOrdinal("DateOfJoin"));
                emp.DateOfJoin = new DateTime(dateofjoin.Year, dateofjoin.Month, dateofjoin.Day);
                emp.Salary = reader.GetDouble(reader.GetOrdinal("Salary"));

                var empAccount = dalWorkers.GetUserInfoById(emp.Id);
                emp.Account.ID = empAccount.ID;
                emp.Manager.Id = reader.GetInt32(reader.GetOrdinal("ManagerId"));
            }
            CloseConnection();

            return emp;
        }

        /// <summary>
        /// Gets list of employees managed by the manager with the specified <c>Id</c>
        /// </summary>
        /// <param name="managerId">The manager's Id</param>
        /// <returns></returns>
        public List<DTO_Employee> GetEmployeesThroughManagerId(int managerId)
        {
            List<DTO_Employee> empList = null;
            string qry = "SELECT * FROM [EMPLOYEES] WHERE ManagerId = @manId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@manId", managerId);

            OpenConnection();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var emp = GetEmployeeInfoAndManagerId(reader.GetInt32(reader.GetOrdinal("Id")));
                empList.Add(emp);
            }
            CloseConnection();

            return empList;
        }

        public DTO_Manager GetManagerInfo(DTO_Employee emp)
        {
            DAL_Manager dalMan = new DAL_Manager();
            return dalMan.GetById(emp.Manager.Id);
        }

        public void Insert(DTO_Employee emp)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "INSERT INTO [EMPLOYEES] VALUES (@workerId, @address, @dateofjoin, @salary, @managerId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            int workerId = dalWorkers.Insert(emp);
            cmd.Parameters.AddWithValue("@workerId", workerId);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@dateofjoin", emp.DateOfJoin);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            cmd.Parameters.AddWithValue("@managerId", emp.Manager.Id);

            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void Delete(DTO_Employee emp)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "DELETE FROM [EMPLOYEES] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", emp.Id);

            dalWorkers.Delete(emp);
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        /// <summary>
        /// Updates the database where the employee's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="empUpdated">The updated employee</param>
        public void Update(DTO_Employee empUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "UPDATE [EMPLOYEE] " +
                "SET Address = @address, DateOfJoin = @doj, " +
                "Salary = @salary, ManagerId = @manId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@address", empUpdated.Address);
            cmd.Parameters.AddWithValue("@doj", empUpdated.DateOfJoin);
            cmd.Parameters.AddWithValue("@salary", empUpdated.Salary);
            cmd.Parameters.AddWithValue("@manId", empUpdated.Manager.Id);

            dalWorkers.Update(empUpdated);
            OpenConnection();
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
