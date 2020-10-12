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


        public static bool IsDate(string date)
        {
            string[] elements = date.Split('/');
            if ((Convert.ToInt32(elements[0]) >= 1) && (Convert.ToInt32(elements[0]) <= 31) && (Convert.ToInt32(elements[1]) >= 1) && (Convert.ToInt32(elements[1]) <= 12) && (Convert.ToInt32(elements[2]) >= 1900))
                return true;
            else return false;
        }

        public DataTable GetAllEmployee()
        {
            DataTable dtb = new DataTable();
            dtb = dalEmployee.GetAllEmployees();
            return dtb;
        }
        public DataTable GetAllEmployees()
        {
            return dalEmployee.GetAllEmployees();
        }
        public DTO_Employee GetById(int id)
        {
            return dalEmployee.GetEmployeeInfoAndManagerId(id);
        }
        public void AddEmployee(DTO_Employee emp)
        {
            dalEmployee.Insert(emp);
        }
        public void DeleteEmployee(DTO_Employee emp)
        {
            dalEmployee.Delete(emp);
        }
        public void EditEmployee(DTO_Employee emp)
        {
            dalEmployee.Update(emp);
        }

    }
}
