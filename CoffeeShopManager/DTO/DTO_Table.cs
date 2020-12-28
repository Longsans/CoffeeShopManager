using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Table
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DTO_Shop Shop = new DTO_Shop();
        public bool Deleted { get; set; }
    }
}
