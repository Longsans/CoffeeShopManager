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
        DAL_Tables dalTables = new DAL_Tables();
        public DTO_Table GetTableById(int tableId, int shopId)
        {
            try
            {
                return dalTables.GetTableById(tableId, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public List<DTO_Table> GetTablesByShopId(int shopId)
        {
            try
            {
                return dalTables.GetTablesByShopId(shopId);
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

        public bool Insert(DTO_Table tab)
        {
            if(dalTables.GetTableById(tab.Id,1)!=null)
            {
                Console.WriteLine("Trung ID");
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void Delete(DTO_Table table)
        {
            try
            {
                dalTables.Delete(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }




    }
}
