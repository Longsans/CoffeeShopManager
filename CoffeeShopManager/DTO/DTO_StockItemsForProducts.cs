using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_StockItemsForProducts
    {
        public DTO_Product Product = new DTO_Product();
        public DTO_StockItem Item = new DTO_StockItem();
        public DTO_Shop Shop = new DTO_Shop();
    }
}
