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
    public class BUS_Customers
    {
        DAL_Customers dalCus = new DAL_Customers();
        public DTO_Customer GetCustomerById(int id)
        {
            try
            {
                return dalCus.GetCustomerById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DTO_Customer GetCustomerByEmail(string email, int shopId)
        {
            try
            {
                return dalCus.GetCustomerByEmail(email, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetCustomerSearchIDFiltered(int id)
        {
            try
            {
                return dalCus.GetCustomerSearchIDFiltered(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetCustomersSearchNameFiltered(string name, int shopId)
        {
            try
            {
                return dalCus.GetCustomersSearchNameFiltered(name, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetCustomerSearchEmailFiltered(string email, int shopId)
        {
            try
            {
                return dalCus.GetCustomerSearchEmailFiltered(email, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public bool Insert(DTO_Customer cus)
        {
            if (dalCus.GetCustomerByEmail(cus.Email, 1) != null)
            {
                Console.WriteLine("Trung email");
                return false;
            }
            else
            {
                dalCus.Insert(cus);
                return true;
            }
        }
        public void Delete(DTO_Customer cus)
        {
            try
            {
                dalCus.Delete(cus);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void Update(DTO_Customer cus)
        {
            try
            {
                dalCus.Update(cus);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
