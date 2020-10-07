using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        public int _Employee_ID { get; set; }
        public string _Employee_Name { get; set; }
        public long _Employee_Phone { get; set; }
        public string _Employee_Gender { get; set; }
        public string _Employee_Address { get; set; }
        public string _Employee_Email { get; set; }
        public string _Employee_DateOfJoin { get; set; }
        public double _Employee_Salary { get; set; }
        public DTO_Employee() { }
        public DTO_Employee(int id, string name, long phone, string gender, string address, string email, string dataofjoin, double salary)
        {
            this._Employee_ID = id;
            this._Employee_Name = name;
            this._Employee_Phone = phone;
            this._Employee_Gender = gender;
            this._Employee_Address = address;
            this._Employee_Email = email;
            this._Employee_DateOfJoin = dataofjoin;
            this._Employee_Salary = salary;
        }


    
    }
}
