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
        DAL_Manager dalManager = new DAL_Manager();
        public DataTable GetAllManagers()
        {
            try
            {
                DataTable dtb = new DataTable();
                dtb = dalManager.GetAllManagers();
                return dtb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Manager GetById(int id)
        {
            try
            {
                return dalManager.GetById(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Manager GetByEmail(string email)
        {
            try
            {
                return dalManager.GetByEmail(email);
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
        public DTO_User GetUserInfoById(int id)
        {
            try
            {
                return dalManager.GetUserInfoById(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(DTO_Manager dtoMan)
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
        public void Update(DTO_Manager dtoman)
        {
            try
            {
                dalManager.Update(dtoman);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
