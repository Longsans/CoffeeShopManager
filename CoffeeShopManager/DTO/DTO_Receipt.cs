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
        public DateTime DateOfPayMent { get; set; }
        public decimal Total { get; set; }
        public string Details { get; set; }
        public int ShopID { get; set; }
        public List<DTO_ReceiptDetails> Items { get; set; }
    }
}
