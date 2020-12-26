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
    public class BUS_Tables
    {
        private string connectionString;
        DAL_Tables dalTables;

        public BUS_Tables(string connString)
        {
            connectionString = connString;
            dalTables = new DAL_Tables(connectionString);
        }

        public DTO_Table GetTableByIdNotDeleted(int tableId, int shopId)
        {
            try
            {
                return dalTables.GetTableByIdNotDeleted(tableId, shopId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO_Table GetTableByIdDeletedAndNotDeleted(int tableId, int shopId)
        {
            return dalTables.GetTableByIdDeletedAndNotDeleted(tableId, shopId);
        }

        public List<DTO_Table> GetTablesByShopId(int shopId)
        {
            try
            {
                return dalTables.GetAllNotDeletedTablesByShopId(shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public List<DTO_Table> GetAvailableTables(int shopId)
        {
            try
            {
                return dalTables.GetAvailableTables(shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public List<DTO_Table> GetOccupiedTables(int shopId)
        {
            try
            {
                return dalTables.GetOccupiedTables(shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public List<DTO_Table> GetUnavailableTables(int shopId)
        {
            try
            {
                return dalTables.GetUnavailableTables(shopId);  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DTO_Table GetTableOfActiveReceipt(int receiptId, int shopId)
        {
            return dalTables.GetTableOfActiveReceipt(receiptId, shopId);
        }

        public DTO_Receipt GetCurrentReceiptOfTable(int tableId, int shopId)
        {
            try
            {
                return dalTables.GetCurrentReceiptOfTable(tableId, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DataTable GetCurrentReceiptIdsAtTable(int tableId, int shopId)
        {
            return dalTables.GetCurrentReceiptIdsAtTable(tableId, shopId);
        }

        public bool CheckReceiptExists(DTO_Table tab)
        {
            return dalTables.CheckReceiptExists(tab);
        }

        public bool Insert(DTO_Table tab)
        {
            if(dalTables.GetTableByIdDeletedAndNotDeleted(tab.Id, tab.Shop.ID)!=null)
            {
                return false;
            }
            else
            {
                dalTables.Insert(tab);
                return true;
            }
        }

        public void Update(DTO_Table tabUpdated)
        {
            try
            {
                dalTables.Update(tabUpdated);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FalseDelete(DTO_Table table)
        {
            dalTables.FalseDelete(table);
        }

        public void TrueDelete(DTO_Table table)
        {
            try
            {
                dalTables.TrueDelete(table);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RestoreDeletedTable(DTO_Table tab)
        {
            dalTables.RestoreDeletedTable(tab);
        }
    }
}
