using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee:DTO_User
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string  Gender { get; set; }
        public string Address { get; set; }
       // public string Email { get; set; }
        public string DateOfJoin { get; set; }
        public double Salary { get; set; }
        public DTO_Employee() { }
        public DTO_Employee(int id, string name, long phone, string gender, string address, string email, string dataofjoin, double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.Gender = gender;
            this.Address = address;
            this.Email = email;
            this.DateOfJoin = dataofjoin;
            this.Salary = salary;
        }


    
    }
}
