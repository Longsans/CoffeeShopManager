using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Manager
    {
        private string connectionString;
        DAL_Manager dalManager;

        public BUS_Manager(string connString)
        {
            connectionString = connString;
            dalManager = new DAL_Manager(connectionString);
        }

        public DataTable GetAllManagers(int shopId)
        {
            try
            {
                DataTable dtb = new DataTable();
                dtb = dalManager.GetAllManagers(shopId);
                return dtb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Manager GetById(string id, int shopId)
        {
            try
            {
                return dalManager.GetById(id, shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Manager GetByUsername(string username)
        {
            try
            {
                return dalManager.GetByUsername(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DTO_Employee> GetEmployeeList(DTO_Manager manager)
        {
            try
            {
                return dalManager.GetEmployeeList(manager);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DTO_User GetUserInfoById(string id, int shopId)
        {
            DAL_Workers dalWr = new DAL_Workers(connectionString);
            var dtoUser = dalWr.GetUserInfoById(id, shopId);

            return dtoUser;
        }

        public DTO_User GetUserInfoByUsername(string username)
        {
            DAL_Workers dalWr = new DAL_Workers(connectionString);
            var dtoUser = dalWr.GetUserInfoByUsername(username);

            return dtoUser;
        }

        public string Insert(DTO_Manager dtoMan)
        {
            try
            {
                return dalManager.Insert(dtoMan);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(DTO_Manager dtoMan)
        {
            try
            {
                dalManager.Delete(dtoMan);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateInfo(DTO_Manager dtoman)
        {
            try
            {
                dalManager.UpdateInfo(dtoman);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInfoAndAccount(DTO_Manager dtoman)
        {
            try
            {
                dalManager.UpdateInfoAndAccount(dtoman);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
