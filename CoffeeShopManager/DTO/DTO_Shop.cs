using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Shop
    {
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string Phone { get; set; }
        public string AuthCode { get; set; }

        public DTO_Shop()
        {

        }
    }
}
