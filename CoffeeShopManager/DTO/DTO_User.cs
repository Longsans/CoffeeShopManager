using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string TypeID { get; set; }
        public DTO_User() { }
        public DTO_User(string email,string password)
        {
            this.Email = email;
            this.PassWord = password;
        }
        public DTO_User(string email, string password, string typeid,int id)
        {
            this.Email = email;
            this.PassWord = password;
            this.TypeID = typeid;
            this.ID = id;
        }
    }
}
