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
    public class BUS_Shop
    {
        DAL_Shop dalShop = new DAL_Shop();
        public DTO_Shop GetShopById(int id)
        {
            try
            {
                return dalShop.GetShopById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public bool Insert(DTO_Shop shop)
        {
            if (dalShop.GetShopById(shop.ID) != null)
            {
                Console.WriteLine("ID trung`");
                return false;
            }
            else
            {
                dalShop.Insert(shop);
                return true;
            }
        }
        public void Delete(DTO_Shop shop)
        {
            try
            {
                dalShop.Delete(shop);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void Update(DTO_Shop shop)
        {
            try
            {
                dalShop.Update(shop);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
