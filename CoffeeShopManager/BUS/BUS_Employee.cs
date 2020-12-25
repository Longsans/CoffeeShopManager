using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Employee
    {
        private string connectionString;
        DAL_Employee dalEmployee;

        public BUS_Employee(string connString)
        {
            connectionString = connString;
            dalEmployee = new DAL_Employee(connectionString);
        }

        public DataTable GetAllEmployee(int shopId)
        {
            try
            {
                DataTable dtb = new DataTable();
                dtb = dalEmployee.GetAllEmployees(shopId);
                return dtb;
            }
            catch(Exception ex)
            {
                throw ex;
            }   
        }
        public DTO_Employee GetEmployeeInfoAndManagerId(string id, int shopId)
        {
            return dalEmployee.GetEmployeeInfoAndManagerId(id, shopId);
        }
        public DTO_Manager GetManagerInfo(DTO_Employee emp)
        {
            try
            {
               return  dalEmployee.GetManagerInfo(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<DTO_Employee> GetEmployeesThroughManagerId(string managerId, int shopId)
        {
            try
            {
                return dalEmployee.GetEmployeesThroughManagerId(managerId, shopId);
            }
            catch (Exception ex)
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

        public void AddEmployee(DTO_Employee emp)
        {
            try
            {
                dalEmployee.Insert(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteEmployee(DTO_Employee emp)
        {
            try
            {
                dalEmployee.Delete(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditEmployee(DTO_Employee emp)
        {
            try
            {
                dalEmployee.UpdateInfo(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EditEmployeeAndAccount(DTO_Employee emp)
        {
            try
            {
                dalEmployee.UpdateInfoAndAccount(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO_Employee GetEmployeeInfoByUsername(string username)
        {
            try
            {
                return dalEmployee.GetEmployeeInfoByUsername(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEmployeesSearchIDFiltered(string id, int shopId)
        {
            return dalEmployee.GetEmployeesSearchIDFiltered(id, shopId);
        }

        public DataTable GetEmployeesSearchNameFiltered(string nameSubstr, int shopId)
        {
            return dalEmployee.GetEmployeesSearchNameFiltered(nameSubstr, shopId);
        }

        public DataTable GetEmployeesSearchGenderFiltered(string gender, int shopId)
        {
            return dalEmployee.GetEmployeesSearchGenderFiltered(gender, shopId);
        }

        public DataTable GetEmployeesSearchPositionFiltered(string position, int shopId)
        {
            return dalEmployee.GetEmployeesSearchPositionFiltered(position, shopId);
        }

        public DataTable GetEmployeesSearchPhoneFiltered(string phone, int shopId)
        {
            return dalEmployee.GetEmployeesSearchPhoneFiltered(phone, shopId);
        }

        public DataTable GetEmployeesSearchEmailFiltered(string email, int shopId)
        {
            return dalEmployee.GetEmployeesSearchEmailFiltered(email, shopId);
        }

        public DataTable GetEmployeesSearchManIDFiltered(string manId, int shopId)
        {
            return dalEmployee.GetEmployeesSearchManIDFiltered(manId, shopId);
        }
    }
}
