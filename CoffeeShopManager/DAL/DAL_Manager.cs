﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Manager : DBConnection
    {
        public DataTable GetAllManagers()
        {
            DAL_Workers dalWorkers = new DAL_Workers();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            DataTable dtMan = dalWorkers.GetAllManagerWorkers();
            if (!connState)
            {
                CloseConnection();
            }

            return dtMan;
        }

        public DTO_Manager GetById(int id)
        {
            DAL_Workers dalWorker = new DAL_Workers();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            DTO_Worker dtoWrk = dalWorker.GetInfoById(id);
            if (!connState)
            {
                CloseConnection();
            }

            DTO_Manager dtoMan = new DTO_Manager(dtoWrk);

            return dtoMan;
        }

        public List<DTO_Employee> GetEmployeeList(DTO_Manager manager)
        {
            DAL_Employee dalEmp = new DAL_Employee();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var lsEmp = dalEmp.GetEmployeesThroughManagerId(manager.Id);
            if (!connState)
            {
                CloseConnection();
            }

            return lsEmp;
        }

        public DTO_User GetUserInfoById(int id)
        {
            DAL_Workers dalWr = new DAL_Workers();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var dtoUser = dalWr.GetUserInfoById(id);
            if (!connState)
            {
                CloseConnection();
            }

            return dtoUser;
        }

        public int Insert(DTO_Manager dtoMan)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "INSERT INTO [MANAGERS] VALUES (@workerId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            int workerId = dalWorkers.Insert(dtoMan);
            cmd.Parameters.AddWithValue("@workerId", workerId);
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

            return workerId;
        }

        public void Delete(DTO_Manager dtoMan)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "DELETE FROM [MANAGERS] WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoMan.Id);

            dalWorkers.Delete(dtoMan);
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

        /// <summary>
        /// Updates the database where the manager's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="dtoManUpdated">The updated user</param>
        public void Update(DTO_Manager dtoManUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalWorkers.Update(dtoManUpdated);
            if (!connState)
            {
                CloseConnection();
            }
        }
    }
}
