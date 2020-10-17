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
        DAL_Employee dalEmployee = new DAL_Employee();
        public DataTable GetAllEmployee()
        {
            try
            {
                DataTable dtb = new DataTable();
                dtb = dalEmployee.GetAllEmployees();
                return dtb;
            }
            catch(Exception ex)
            {
                throw ex;
            }   
        }
        public DTO_Employee GetEmployeeInfoAndManagerId(int id)
        {
            return dalEmployee.GetEmployeeInfoAndManagerId(id);
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
        public List<DTO_Employee> GetEmployeesThroughManagerId(int managerId)
        {
            try
            {
                return dalEmployee.GetEmployeesThroughManagerId(managerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                dalEmployee.Update(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Employee GetEmployeeInfoByEmail(string email)
        {
            try
            {
                return dalEmployee.GetEmployeeInfoByEmail(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetNextEmployeeID()
        {
            
            try
            {
                DAL_Workers dalWor = new DAL_Workers();
                return dalWor.GetNextWorkerId();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
