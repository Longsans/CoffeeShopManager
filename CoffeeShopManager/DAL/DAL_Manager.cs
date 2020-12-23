using System;
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
        public DataTable GetAllManagers(int shopId)
        {
            DAL_Workers dalWorkers = new DAL_Workers();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            DataTable dtMan = dalWorkers.GetAllManagerWorkers(shopId);
            if (!connState)
            {
                CloseConnection();
            }

            return dtMan;
        }

        public DTO_Manager GetById(string id, int shopId)
        {
            DAL_Workers dalWorker = new DAL_Workers();
            DTO_Manager dtoMan = null;

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            DTO_Worker dtoWrk = dalWorker.GetById(id, shopId);
            if (!connState)
            {
                CloseConnection();
            }

            //  DTO_Manager dtoMan = new DTO_Manager(dtoWrk);
            if (dtoWrk != null)
            {
                dtoMan = new DTO_Manager(dtoWrk);
            }

            return dtoMan;
        }

        public DTO_Manager GetByUsername(string username)
        {
            DTO_Manager man;
            DAL_Workers dalWorkers = new DAL_Workers();
            DTO_Worker dtoWorker = dalWorkers.GetByUsername(username);
            try
            {
                man = new DTO_Manager(dtoWorker);
            }
            catch
            {
                return null;
            }

            return man;
        }

        public List<DTO_Employee> GetEmployeeList(DTO_Manager manager)
        {
            DAL_Employee dalEmp = new DAL_Employee();

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var lsEmp = dalEmp.GetEmployeesThroughManagerId(manager.Id, manager.Shop.ID);
            if (!connState)
            {
                CloseConnection();
            }

            return lsEmp;
        }

        public string Insert(DTO_Manager dtoMan)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "INSERT INTO [MANAGERS] VALUES (@workerId, @shopId)";
            bool workerInserted = false;
            SqlCommand cmd = new SqlCommand(qry, this.conn);

            try
            {
                dtoMan.Id = dalWorkers.Insert(dtoMan);
                workerInserted = true;
                cmd.Parameters.AddWithValue("@workerId", dtoMan.Id);
                cmd.Parameters.AddWithValue("@shopId", dtoMan.Shop.ID);
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

                return dtoMan.Id;
            }
            catch (Exception e)
            {
                if (workerInserted)
                {
                    dalWorkers.Delete(dtoMan);
                }
                throw e;
            }
        }

        public void Delete(DTO_Manager dtoMan)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            string qry = "DELETE FROM [MANAGERS] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoMan.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoMan.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            dalWorkers.Delete(dtoMan);
            if (!connState)
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Updates the database where the manager's data has changed, using <c>Id</c> the as identifier
        /// </summary>
        /// <param name="dtoManUpdated">The updated user</param>
        public void UpdateInfo(DTO_Manager dtoManUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalWorkers.UpdateInfo(dtoManUpdated);
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void UpdateInfoAndAccount(DTO_Manager dtoManUpdated)
        {
            DAL_Workers dalWorkers = new DAL_Workers();
            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            dalWorkers.UpdateInfoAndAccount(dtoManUpdated);
            if (!connState)
            {
                CloseConnection();
            }
        }
    }
}
