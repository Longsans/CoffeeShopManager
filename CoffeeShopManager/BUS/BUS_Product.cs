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
        private string connectionString;
        DAL_Products dalProduct;

        public BUS_Product(string connString)
        {
            connectionString = connString;
            dalProduct = new DAL_Products(connectionString);
        }

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
        public DTO_Product GetByIdNotDeleted(int id, int shopId)
        {
            try
            {               
                return dalProduct.GetByIdNotDeleted(id, shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DTO_Product GetByIdDeletedAndNotDeleted(int id, int shopId)
        {
            return dalProduct.GetByIdDeletedAndNotDeleted(id, shopId);
        }

        public DTO_Product GetByNameNotDeleted(string name, int shopId)
        {
            try
            {
                return dalProduct.GetByNameNotDeleted(name, shopId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DTO_Product GetByNameDeletedAndNotDeleted(string name, int shopId)
        {
            return dalProduct.GetByNameDeletedAndNotDeleted(name, shopId);
        }

        public bool CheckProductReceiptsExist(DTO_Product dtopro)
        {
            return dalProduct.CheckReceiptDetailsExist(dtopro);
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

        public DataTable GetProductsSearchIDFiltered(int id, int shopId)
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

        public DataTable GetDataTableItemsOfProduct(int productId, int shopId)
        {
            return dalProduct.GetDataTableItemsOfProduct(productId, shopId);
        }

        public DTO_StockItemForProduct GetItemForProduct(int itemId, int productId, int shopId)
        {
            return dalProduct.GetItemForProduct(itemId, productId, shopId);
        }

        public void AddItemForProduct(DTO_StockItemForProduct itemForPro)
        {
            dalProduct.AddItemForProduct(itemForPro);
        }

        public void RemoveItemForProduct(DTO_StockItemForProduct itemForPro)
        {
            dalProduct.RemoveItemForProduct(itemForPro);
        }

        public void RemoveAllItemsForProductByProductId(int productId, int shopId)
        {
            dalProduct.RemoveAllItemsForProductByProductId(productId, shopId);
        }

        public bool InsertWithoutImage(DTO_Product dtoPro)
        {
            try
            {
                if (dalProduct.GetByNameDeletedAndNotDeleted(dtoPro.Name, dtoPro.Shop.ID) == null)
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
        public bool FalseDelete(DTO_Product dtoPro)
        {
            try
            {
                    dalProduct.FalseDelete(dtoPro);
                    return true;
               // else return false;                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void TrueDelete(DTO_Product dtoPro)
        {
            dalProduct.TrueDelete(dtoPro);
        }

        public void RestoreDeletedProduct(DTO_Product dtoPro)
        {
            dalProduct.RestoreDeletedProduct(dtoPro);
        }

        public bool Update(DTO_Product dtoPro)
        {
            try
            {
                if (dalProduct.GetByIdNotDeleted(dtoPro.Id, dtoPro.Shop.ID) != null)
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
