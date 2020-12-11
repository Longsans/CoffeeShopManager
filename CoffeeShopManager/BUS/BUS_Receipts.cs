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
        DAL_Receipts dalReceipts = new DAL_Receipts();
        public DTO_Receipt GetReceiptById(int id)
        {
            try
            {
                return dalReceipts.GetReceiptById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public List<DTO_ReceiptDetails> GetReceiptDetailsListById(int receiptId)
        {
            try
            {
                return dalReceipts.GetReceiptDetailsListById(receiptId);
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
        public DataTable GetReceiptDetailsGridViewByReceiptId(int receiptId)
        {
            try
            {
                return dalReceipts.GetReceiptDetailsGridViewByReceiptId(receiptId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetReceiptSearchIdFiltered(int id)
        {
            try
            {
                return dalReceipts.GetReceiptSearchIdFiltered(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public DataTable GetReceiptSearchCustomersIdFiltered(int customerId)
        {
            try
            {
                return dalReceipts.GetReceiptSearchCustomersIdFiltered(customerId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DataTable GetReceiptSearchDateOfPaymentFiltered(DateTime dop)
        {
            return dalReceipts.GetReceiptSearchDateOfPaymentFiltered(dop);
        }

        public DTO_Table GetTableOfReceipt(int receiptId)
        {
            try
            {
                return dalReceipts.GetTableOfReceipt(receiptId);
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
