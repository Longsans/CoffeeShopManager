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
    public class BUS_Receipts
    {
        private string connectionString;
        DAL_Receipts dalReceipts;

        public BUS_Receipts(string connString)
        {
            connectionString = connString;
            dalReceipts = new DAL_Receipts(connectionString);
        }

        public DTO_Receipt GetReceiptById(int id, int shopId)
        {
            try
            {
                return dalReceipts.GetReceiptById(id, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public List<DTO_ReceiptDetails> GetReceiptDetailsListById(int receiptId, int shopId)
        {
            try
            {
                return dalReceipts.GetReceiptDetailsListById(receiptId, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetAllReceipts(int shopId)
        {
            try
            {
                return dalReceipts.GetAllReceipts(shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetReceiptDetailsGridViewByReceiptId(int receiptId, int shopId)
        {
            try
            {
                return dalReceipts.GetReceiptDetailsGridViewByReceiptId(receiptId, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetReceiptSearchIdFiltered(int id, int shopId)
        {
            try
            {
                return dalReceipts.GetReceiptSearchIdFiltered(id, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetReceiptSearchCustomersIdFiltered(int customerId, int shopId)
        {
            try
            {
                return dalReceipts.GetReceiptSearchCustomersIdFiltered(customerId, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DataTable GetReceiptSearchEmployeesIdFiltered(string empId, int shopId)
        {
            return dalReceipts.GetReceiptSearchEmployeesIdFiltered(empId, shopId);
        }

        public DataTable GetReceiptSearchDateOfPaymentFiltered(DateTime dop, int shopId)
        {
            return dalReceipts.GetReceiptSearchDateOfPaymentFiltered(dop, shopId);
        }

        public DTO_Table GetTableOfReceipt(int receiptId, int shopId)
        {
            try
            {
                return dalReceipts.GetTableOfReceipt(receiptId, shopId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void InsertTakeAwayReceipt(DTO_Receipt rec)
        {
            try
            {
                dalReceipts.InsertTakeAwayReceipt(rec);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void InsertSittingReceipt(DTO_Receipt rec, DTO_Table tab)
        {
            try
            {
                dalReceipts.InsertSittingReceipt(rec, tab);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        private void InsertReceiptDetails(DTO_Receipt rec)
        {
            try
            {
               // dalReceipts.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void DeleteReceipt(DTO_Receipt rec)
        {
            try
            {
                dalReceipts.DeleteReceipt(rec);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
