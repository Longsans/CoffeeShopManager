﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee : DTO_Worker
    {

        public DateTime DateOfJoin { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public DTO_Manager Manager { get; set; }
        public DTO_Employee() { }
        public DTO_Employee(DTO_Worker dtoWr)
        {
            this.Firstname = dtoWr.Firstname;
            this.Lastname = dtoWr.Lastname;
            this.Gender = dtoWr.Gender;
            this.Position = dtoWr.Position;
            this.Phone = dtoWr.Phone;
            this.Account.Email = dtoWr.Account.Email;
            this.Birthdate = dtoWr.Birthdate;
        }
        public DTO_Employee(int year,int month,int day)
        {
            DateOfJoin = new DateTime(year, month, day);
        }
    }
}
