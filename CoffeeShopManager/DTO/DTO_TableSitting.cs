using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TableSitting
    {
        public DTO_Receipt Receipt { get; set; }
        public DTO_Table Table { get; set; }
        public bool Sitting { get; set; }
    }
}
