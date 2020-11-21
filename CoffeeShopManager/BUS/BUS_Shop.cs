using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            return dalShop.GetShopById(id);
        }

        public int Insert(DTO_Shop shop)
        {
            return dalShop.Insert(shop);
        }

        public void Delete(DTO_Shop shop)
        {
            dalShop.Delete(shop);
        }

        public void Update(DTO_Shop shopUpdated)
        {
            dalShop.Update(shopUpdated);
        }

        public int GetNextShopId()
        {
            return dalShop.GetNextShopId();
        }

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string EncodeAuthCode(string rawAuthCode)
        {
            return ComputeSha256Hash(rawAuthCode);
        }

        public bool VerifyShop(DTO_Shop shop)
        {
            DTO_Shop original = GetShopById(shop.ID);
            if (original.AuthCode == shop.AuthCode)
            {
                return true;
            }
            else return false;
        }
    }
}
