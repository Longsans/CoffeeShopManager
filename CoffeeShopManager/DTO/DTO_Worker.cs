using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace DTO
{
    public class DTO_Worker
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public long Phone { get; set; }
        public DateTime Birthdate { get; set; }

        public DTO_User Account = new DTO_User();


    }
}
