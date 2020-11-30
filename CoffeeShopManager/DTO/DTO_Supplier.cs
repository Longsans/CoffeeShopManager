using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DTO_Shop Shop { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
