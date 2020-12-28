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
        public string Username { get; set; }
        public string PassWord { get; set; }

        public string TypeId { get; set; }
        public bool Deleted { get; set; }
        public DTO_User() { }
        public DTO_User(string username, string password)
        {
            this.Username = username;
            this.PassWord = password;
        }
        public DTO_User(string username,string password,string typeid)
        {
            this.Username = username;
            this.PassWord = password;
            this.TypeId = typeid;
        }
    }
}
