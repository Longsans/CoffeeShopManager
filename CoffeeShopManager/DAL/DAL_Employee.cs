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
        public DAL_Employee(string connString) : base(connString)
        {

        }

        public DataTable GetAllEmployees(int shopId)
        {
            DataTable dtEmp = new DataTable();
            string qry = "SELECT EMPLOYEES.Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
                "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], " +
                "ManagerId AS [Manager's ID] " +
                "FROM [WORKERS] INNER JOIN [EMPLOYEES] " +
                "ON WORKERS.Id = EMPLOYEES.Id " +
                "AND WORKERS.ShopId = EMPLOYEES.ShopId " +
                "WHERE EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmp);

            return dtEmp;
        }

        /// <summary>Gets the employee with the specified <c>Id</c> and only the <c>Id</c> of the <c>Manager</c> property; returns <returns>null</returns> if no employee with such <c>Id</c> exists</summary>
        public DTO_Employee GetEmployeeInfoAndManagerId(string id, int shopId) // Only gets the manager's id, which is already included in [EMPLOYEES] table
        {
            
            DTO_Employee emp = null;
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            string qry = "SELECT * FROM [EMPLOYEES] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                emp = new DTO_Employee(dalWorkers.GetById(reader.GetString(reader.GetOrdinal("Id")), shopId))
                {
                    Address = reader.GetString(reader.GetOrdinal("Address")),
                    Salary = decimal.Round((decimal)reader["Salary"], 2, MidpointRounding.AwayFromZero),
                    Manager = new DTO_Manager
                    {
                        Id = reader.GetString(reader.GetOrdinal("ManagerId"))
                    }
                };

                var dateofjoin = reader.GetDateTime(reader.GetOrdinal("DateOfJoin"));
                emp.DateOfJoin = new DateTime(dateofjoin.Year, dateofjoin.Month, dateofjoin.Day);

                var empAccount = dalWorkers.GetUserInfoById(emp.Id, shopId);
                emp.Account.ID = empAccount.ID;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return emp;
        }

        public DTO_Employee GetEmployeeInfoByUsername(string username)
        {
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            DTO_Employee emp = null;
            var wr = dalWorkers.GetByUsername(username);

            if (wr != null)
            {
                emp = new DTO_Employee(wr);
                string qry = "SELECT * FROM [EMPLOYEES] " +
                    "WHERE Id = @id AND ShopId = @shopId";
                SqlCommand cmd = new SqlCommand(qry, this.conn);
                cmd.Parameters.AddWithValue("@id", emp.Id);
                cmd.Parameters.AddWithValue("@shopId", emp.Shop.ID);

                var connState = (this.conn.State == ConnectionState.Open);
                if (!connState)
                {
                    OpenConnection();
                }
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    emp.Address = reader.GetString(reader.GetOrdinal("Address"));

                    var dateofjoin = reader.GetDateTime(reader.GetOrdinal("DateOfJoin"));
                    emp.DateOfJoin = new DateTime(dateofjoin.Year, dateofjoin.Month, dateofjoin.Day);
                    emp.Salary = decimal.Round((decimal)reader["Salary"], 2, MidpointRounding.AwayFromZero);

                    emp.Account.ID = wr.Account.ID;
                    emp.Manager.Id = reader.GetString(reader.GetOrdinal("ManagerId"));
                }
                if (!connState)
                {
                    CloseConnection();
                }
            }
            
            return emp;
        }

        public DTO_Employee GetByEmail(string email, int shopId)
        {
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            DTO_Employee emp = null;
            string qry = "SELECT * " +
                "FROM EMPLOYEES " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            var wr = dalWorkers.GetByEmail(email, shopId);
            if (wr != null)
            {
                emp = new DTO_Employee(wr);
                cmd.Parameters.AddWithValue("@id", wr.Id);
                cmd.Parameters.AddWithValue("@shopId", shopId);

                var connState = (this.conn.State == ConnectionState.Open);
                if (!connState)
                {
                    OpenConnection();
                }
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    emp.Address = reader.GetString(reader.GetOrdinal("Address"));

                    var dateofjoin = reader.GetDateTime(reader.GetOrdinal("DateOfJoin"));
                    emp.DateOfJoin = new DateTime(dateofjoin.Year, dateofjoin.Month, dateofjoin.Day);
                    emp.Salary = decimal.Round((decimal)reader["Salary"], 2, MidpointRounding.AwayFromZero);

                    emp.Account.ID = wr.Account.ID;
                    emp.Manager.Id = reader.GetString(reader.GetOrdinal("ManagerId"));
                }
                if (!connState)
                {
                    CloseConnection();
                }
            }

            return emp;
        }

        /// <summary>
        /// Gets list of employees managed by the manager with the specified <c>Id</c>
        /// </summary>
        /// <param name="managerId">The manager's Id</param>
        /// <returns></returns>
        public List<DTO_Employee> GetEmployeesThroughManagerId(string managerId, int shopId)
        {
            List<DTO_Employee> empList = new List<DTO_Employee>();
            string qry = "SELECT Id FROM [EMPLOYEES] " +
                "WHERE ManagerId = @manId AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@manId", managerId);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var emp = GetEmployeeInfoAndManagerId(reader.GetString(reader.GetOrdinal("Id")), shopId);
                empList.Add(emp);
            }
            if (!connState)
            {
                CloseConnection();
            }

            if (empList.Count > 0) return empList;
            return null;
        }

        public DTO_Manager GetManagerInfo(DTO_Employee emp)
        {
            DAL_Manager dalMan = new DAL_Manager(this.connectionString);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var dtoMan = dalMan.GetById(emp.Manager.Id, emp.Shop.ID);
            if (!connState)
            {
                CloseConnection();
            }

            return dtoMan;
        }

        public DataTable GetEmployeesSearchIDFiltered(string id, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE [EMPLOYEES].Id = @id AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchNameFiltered(string nameSubstr, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE CONCAT(FirstName, ' ', LastName) LIKE '%' + @nameSubstr + '%' " +
               "AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@nameSubstr", nameSubstr);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchGenderFiltered(string gender, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE Gender = @gender " +
               "AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchPositionFiltered(string position, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE Position = @position " +
               "AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchPhoneFiltered(string phone, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE PhoneNumber = @phone " +
               "AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }
        public DataTable GetEmployeesSearchEmailFiltered(string email, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE EmailAddress = @email " +
               "AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchManIDFiltered(string manId, int shopId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id AS ID, FirstName AS [First Name], LastName AS [Last Name], " +
               "Gender, Position, PhoneNumber AS [Phone], EmailAddress AS [Email], ManagerId AS [Manager's ID] " +
               " FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "AND EMPLOYEES.ShopId = WORKERS.ShopId " +
               "WHERE ManagerId = @manId " +
               "AND EMPLOYEES.ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@manId", manId);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }


        public void Insert(DTO_Employee emp)
        {
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            string qry = "INSERT INTO [EMPLOYEES] " +
                "VALUES (@workerId, @address, @dateofjoin, @salary, @managerId, @shopId)";
            bool workerInserted = false;
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            try
            {
                emp.Id = dalWorkers.Insert(emp);
                workerInserted = true;
                cmd.Parameters.AddWithValue("@workerId", emp.Id);
                cmd.Parameters.AddWithValue("@address", emp.Address);
                cmd.Parameters.AddWithValue("@dateofjoin", emp.DateOfJoin);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);
                cmd.Parameters.AddWithValue("@managerId", emp.Manager.Id);
                cmd.Parameters.AddWithValue("@shopId", emp.Shop.ID);

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
            catch (Exception e)
            {
                if (workerInserted)
                {
                    dalWorkers.Delete(emp);
                }
                throw e;
            }
        }

        public void Delete(DTO_Employee emp)
        {
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            string qry = "DELETE FROM [EMPLOYEES] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.Parameters.AddWithValue("@shopId", emp.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            dalWorkers.Delete(emp);
            if (!connState)
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Updates the database where the employee's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="empUpdated">The updated employee</param>
        public void UpdateInfo(DTO_Employee empUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            string qry = "UPDATE [EMPLOYEES] " +
                "SET Address = @address, DateOfJoin = @doj, " +
                "Salary = @salary, ManagerId = @manId " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@address", empUpdated.Address);
            cmd.Parameters.AddWithValue("@doj", empUpdated.DateOfJoin);
            cmd.Parameters.AddWithValue("@salary", empUpdated.Salary);
            cmd.Parameters.AddWithValue("@manId", empUpdated.Manager.Id);
            cmd.Parameters.AddWithValue("@id", empUpdated.Id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalWorkers.UpdateInfo(empUpdated);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void UpdateInfoAndAccount(DTO_Employee empUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers(this.connectionString);
            string qry = "UPDATE [EMPLOYEES] " +
                "SET Address = @address, DateOfJoin = @doj, " +
                "Salary = @salary, ManagerId = @manId " +
                "WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@address", empUpdated.Address);
            cmd.Parameters.AddWithValue("@doj", empUpdated.DateOfJoin);
            cmd.Parameters.AddWithValue("@salary", empUpdated.Salary);
            cmd.Parameters.AddWithValue("@manId", empUpdated.Manager.Id);
            cmd.Parameters.AddWithValue("@id", empUpdated.Id);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalWorkers.UpdateInfoAndAccount(empUpdated);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }
    }
}
