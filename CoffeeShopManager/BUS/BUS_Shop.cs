using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Shop
    {
        private string connectionString;
        DAL_Shop dalShop;
        DAL_Receipts dalrec;

        public BUS_Shop(string connString)
        {
            connectionString = connString;
            dalShop = new DAL_Shop(connectionString);
            dalrec = new DAL_Receipts(connectionString);
        }

        public DTO_Shop GetShopById(int id)
        {
            return dalShop.GetShopById(id);
        }

        public DataTable GetDataTableDailyIncome(int month, int year, int shopId)
        {
            return dalrec.GetDataTableDailyIncome(month, year, shopId);
        }

        public DataTable GetDataTableLastNDaysIncome(int numberOfDays, int shopId)
        {
            return dalrec.GetDataTableLastNDaysIncome(numberOfDays, shopId);
        }

        public DataTable GetDataTableMonthlyIncome(int year, int shopId)
        {
            return dalrec.GetDataTableMonthlyIncome(year, shopId);
        }

        public DataTable GetDataTableAnnualIncome(int shopId)
        {
            return dalrec.GetDataTableAnnualIncome(shopId);
        }

        public DataTable GetDataTableQuarterlyIncome(int year, int shopId)
        {
            return dalrec.GetDataTableQuarterlyIncome(year, shopId);
        }

        public decimal GetTotalMonthlyIncome(int month, int year, int shopId)
        {
            return dalrec.GetTotalMonthlyIncome(month, year, shopId);
        }

        public decimal GetTotalLastNDaysIncome(int numberOfDays, int shopId)
        {
            return dalrec.GetTotalLastNDaysIncome(numberOfDays, shopId);
        }

        public decimal GetTotalAnnualIncome(int year, int shopId)
        {
            return dalrec.GetTotalAnnualIncome(year, shopId);
        }

        public decimal GetTotalAllTimeIncome(int shopId)
        {
            return dalrec.GetTotalAllTimeIncome(shopId);
        }

        public decimal GetAverageDailyIncome(int month, int year, int shopId)
        {
            return dalrec.GetAverageDailyIncome(month, year, shopId);
        }

        public decimal GetAverageLastNDaysIncome(int numberOfDays, int shopId)
        {
            return dalrec.GetAverageLastNDaysIncome(numberOfDays, shopId);
        }

        public decimal GetAverageMonthlyIncome(int year, int shopId)
        {
            return dalrec.GetAverageMonthlyIncome(year, shopId);
        }

        public decimal GetAverageQuarterlyIncome(int year, int shopId)
        {
            return dalrec.GetAverageQuarterlyIncome(year, shopId);
        }

        public decimal GetAverageAnnualIncome(int shopId)
        {
            return dalrec.GetAverageAnnualIncome(shopId);
        }

        public DataTable GetDatatableTotalLastNDaysProductSales(int numberOfDays, int shopId)
        {
            return dalrec.GetDatatableTotalLastNDaysProductSales(numberOfDays, shopId);
        }

        public DataTable GetDatatableTotalMonthlyProductSales(int month, int year, int shopId)
        {
            return dalrec.GetDatatableTotalMonthlyProductSales(month, year, shopId);
        }

        public DataTable GetDatatableTotalQuarterlyProductSales(int quarter, int year, int shopId)
        {
            return dalrec.GetDatatableTotalQuarterlyProductSales(quarter, year, shopId);
        }

        public DataTable GetDatatableTotalAnnualProductSales(int year, int shopId)
        {
            return dalrec.GetDatatableTotalAnnualProductSales(year, shopId);
        }

        public DataTable GetDatatableTotalAllTimeProductSales(int shopId)
        {
            return dalrec.GetDatatableTotalAllTimeProductSales(shopId);
        }

        public int GetTotalAllProductSalesFromDataTable(DataTable dt)
        {
            int sales = -1;
            foreach (DataRow row in dt.Rows)
            {
                if (sales == -1)
                {
                    sales = 0;
                }
                sales += (int)row["Sales"];
            }

            return sales;
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
