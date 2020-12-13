using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Receipt
    {
        public int Id { get; set; }
        public DTO_Customer Customer { get; set; }
        public DTO_Employee Employee { get; set; }
        public DateTime DateOfPayMent { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string Details { get; set; }
        public DTO_Shop Shop = new DTO_Shop();
        public List<DTO_ReceiptDetails> Items = new List<DTO_ReceiptDetails>();
        public DTO_Receipt()
        {

        }
    }
}
