using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {
        public int ID { get;}
        public string Email { get; set; }
        public string PassWord { get; set; }
        public DTO_User() { }
        public DTO_User(string email,string password)
        {
            this.Email = email;
            this.PassWord = password;
        }
    }
}
