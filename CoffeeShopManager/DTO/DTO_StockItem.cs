using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_StockItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DTO_Supplier Supplier { get; set; }
        public DTO_Shop Shop { get; set; }
    }
}
