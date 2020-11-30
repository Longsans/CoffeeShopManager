using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public DTO_Shop Shop = new DTO_Shop();
        public DTO_Customer()
        {

        }
        public DTO_Customer(int id, string fname, string lname, string email, DateTime bdate, int shopId)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Birthdate = bdate;
            Shop.ID = shopId;
        }
    }
}
