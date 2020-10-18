﻿using System;
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
            string qry = "SELECT ManagerId FROM [EMPLOYEES]";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            
            ada.Fill(dtEmp);
              var connState = (this.conn.State == ConnectionState.Open);
              if (!connState)
              {
                  OpenConnection();
              }
              var dtWorkers = dalWr.GetAllEmployeeWorkers();
              var dtMerged = dtWorkers.Clone();
              for (int i = 0; i < dtEmp.Columns.Count; ++i)
              {
                  dtMerged.Columns.Add(dtEmp.Columns[i].ColumnName);
              }

              var workerTab = dtWorkers.AsEnumerable();
              var empTab = dtEmp.AsEnumerable();
              var mergedRows = workerTab.Zip(empTab, (r1, r2) => r1.ItemArray.Concat(r2.ItemArray).ToArray());
              foreach (object[] row in mergedRows)
              {
                  dtMerged.Rows.Add(row);
              }
              if (!connState)
              {
                  CloseConnection();
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

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                emp = new DTO_Employee(dalWorkers.GetInfoById(reader.GetInt32(reader.GetOrdinal("Id"))))
                {
                    Address = reader.GetString(reader.GetOrdinal("Address"))
                };

                var dateofjoin = reader.GetDateTime(reader.GetOrdinal("DateOfJoin"));
                emp.DateOfJoin = new DateTime(dateofjoin.Year, dateofjoin.Month, dateofjoin.Day);
                emp.Salary = reader.GetDecimal(reader.GetOrdinal("Salary"));

                var empAccount = dalWorkers.GetUserInfoById(emp.Id);
                emp.Account.ID = empAccount.ID;
                emp.Manager = new DTO_Manager
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ManagerId"))
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return emp;
        }

        public DTO_Employee GetEmployeeInfoByEmail(string email)
        {
            DTO_Employee emp = null;
            DAL_Workers dalWorkers = new DAL_Workers();
            emp = new DTO_Employee(dalWorkers.GetInfoByEmail(email));
            string qry = "SELECT * FROM [EMPLOYEES] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", emp.Id);

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
                emp.Salary = reader.GetDecimal(reader.GetOrdinal("Salary"));

                var empAccount = dalWorkers.GetUserInfoById(emp.Id);
                emp.Account.ID = empAccount.ID;
                emp.Manager = new DTO_Manager
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ManagerId"))
                };
            }
            if (!connState)
            {
                CloseConnection();
            }

            return emp;
        }

        /// <summary>
        /// Gets list of employees managed by the manager with the specified <c>Id</c>
        /// </summary>
        /// <param name="managerId">The manager's Id</param>
        /// <returns></returns>
        public List<DTO_Employee> GetEmployeesThroughManagerId(int managerId)
        {
            List<DTO_Employee> empList = new List<DTO_Employee>();
            string qry = "SELECT Id FROM [EMPLOYEES] WHERE ManagerId = @manId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@manId", managerId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var emp = GetEmployeeInfoAndManagerId(reader.GetInt32(reader.GetOrdinal("Id")));
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
            DAL_Manager dalMan = new DAL_Manager();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var dtoMan = dalMan.GetById(emp.Manager.Id);
            if (!connState)
            {
                CloseConnection();
            }

            return dtoMan;
        }

        public DataTable GetEmployeesSearchIDFiltered(int id)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE [EMPLOYEES].Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchNameFiltered(string nameSubstr)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE CONCAT(FirstName, ' ', LastName) LIKE '%' + @nameSubstr + '%'";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@nameSubstr", nameSubstr);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchGenderFiltered(string gender)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE Gender = @gender";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@gender", gender);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchPositionFiltered(string position)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE Position = @position";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@position", position);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchPhoneFiltered(string phone)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE PhoneNumber = @phone";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }
        public DataTable GetEmployeesSearchEmailFiltered(string email)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               "FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE EmailAddress = @email";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }

        public DataTable GetEmployeesSearchManIDFiltered(int manId)
        {
            DataTable dtEmpFiltered = new DataTable();
            string qry = "SELECT [EMPLOYEES].Id, FirstName AS [First Name], LastName, " +
               "Gender, Position, PhoneNumber, EmailAddress, ManagerId " +
               " FROM [EMPLOYEES] INNER JOIN [WORKERS] " +
               "ON [EMPLOYEES].Id = [WORKERS].Id " +
               "WHERE ManagerId = @manId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@manId", manId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtEmpFiltered);

            return dtEmpFiltered;
        }


        public void Insert(DTO_Employee emp)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            DAL_Manager dalMan = new DAL_Manager();
            string qry = "INSERT INTO [EMPLOYEES] VALUES (@workerId, @address, @dateofjoin, @salary, @managerId)";
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
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "DELETE FROM [EMPLOYEES] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", emp.Id);

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
        public void Update(DTO_Employee empUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
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
            dalWorkers.Update(empUpdated);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }
    }
}
