using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
   public class BUS_Product
    {
        DAL_Products dalProduct = new DAL_Products();
        public DataTable GetAllProducts()
        {
            try
            {
                return dalProduct.GetAllProducts();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public DTO_Product GetById(int id)
        {
            try
            {               
                    return dalProduct.GetById(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Product GetByName(string name)
        {
            try
            {
                return dalProduct.GetByName(name);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetAllProductsOfType(string type)
        {
            try
            {
                return dalProduct.GetAllProductsOfType(type);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllDrinks()
        {
            try
            {
                return GetAllProductsOfType("Drink");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllFood()
        {
            try
            {
                return GetAllProductsOfType("Food");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllOtherProducts()
        {
            try
            {
                return GetAllProductsOfType("Other");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetProductsSearchIDFiltered(int id)
        {
            return dalProduct.GetProductsSearchIDFiltered(id);
        }

        public DataTable GetProductsSearchNameFiltered(string namesubstr)
        {
            return dalProduct.GetProductsSearchNameFiltered(namesubstr);
        }

        public DataTable GetProductsSearchTypeFiltered(string type)
        {
            return dalProduct.GetProductsSearchTypeFiltered(type);
        }

        public DataTable GetProductsSearchPriceFiltered(int lowerBound, int upperBound)
        {
            return dalProduct.GetProductsSearchPriceFiltered(lowerBound, upperBound);
        }

        public bool InsertWithoutImage(DTO_Product dtoPro)
        {
            try
            {
                if (dalProduct.GetByName(dtoPro.Name) == null)
                {
                    dalProduct.InsertWithoutImage(dtoPro);
                    return true;
                }
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void InsertWithImage(DTO_Product dtoPro)
        {
            try
            {
                dalProduct.InsertWithImage(dtoPro);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(DTO_Product dtoPro)
        {
            try
            {
                dalProduct.Delete(dtoPro);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(DTO_Product dtoPro)
        {
            try
            {
                if (dalProduct.GetById(dtoPro.Id) != null)
                {
                    dalProduct.Update(dtoPro);
                    return true;
                }
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
