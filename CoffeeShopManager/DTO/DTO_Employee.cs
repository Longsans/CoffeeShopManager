using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee : DTO_Worker
    {

        public DateTime DateOfJoin { get; set; }
        public double Salary { get; set; }
        public DTO_Employee() { }
        public DTO_Employee(string firstname, string lastname, long phone, string gender, string address, string email, DateTime dataofjoin, double salary)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Phone = phone;
            this.Gender = gender;
            this.Account.Email = email;
            this.DateOfJoin = dataofjoin;
            this.Salary = salary;
        }
    }
}
