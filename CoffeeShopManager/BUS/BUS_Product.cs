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
        public DataTable GetAllProductsWithImages(int shopId)
        {
            try
            {
                return dalProduct.GetAllProductsWithImages(shopId);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public DTO_Product GetById(string id, int shopId)
        {
            try
            {               
                    return dalProduct.GetById(id, shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DTO_Product GetByName(string name, int shopId)
        {
            try
            {
                return dalProduct.GetByName(name, shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetAllProductsOfType(string type, int shopId)
        {
            try
            {
                return dalProduct.GetAllProductsOfType(type, shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllDrinks(int shopId)
        {
            try
            {
                return GetAllProductsOfType("Drink", shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllFood(int shopId)
        {
            try
            {
                return GetAllProductsOfType("Food", shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllOtherProducts(int shopId)
        {
            try
            {
                return GetAllProductsOfType("Others", shopId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetProductsSearchIDFiltered(string id, int shopId)
        {
            return dalProduct.GetProductsSearchIDFiltered(id, shopId);
        }

        public DataTable GetProductsSearchNameFiltered(string namesubstr, int shopId)
        {
            return dalProduct.GetProductsSearchNameFiltered(namesubstr, shopId);
        }

        public DataTable GetProductsSearchTypeFiltered(string type, int shopId)
        {
            return dalProduct.GetProductsSearchTypeFiltered(type, shopId);
        }

        public DataTable GetProductsSearchPriceFiltered(int lowerBound, int upperBound, int shopId)
        {
            return dalProduct.GetProductsSearchPriceFiltered(lowerBound, upperBound, shopId);
        }

        public bool InsertWithoutImage(DTO_Product dtoPro)
        {
            try
            {
                if (dalProduct.GetByName(dtoPro.Name, dtoPro.Shop.ID) == null)
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
               // else return false;                
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
                if (dalProduct.GetById(dtoPro.Id, dtoPro.Shop.ID) != null)
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
