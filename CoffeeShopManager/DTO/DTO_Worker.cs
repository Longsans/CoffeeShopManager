﻿using System;
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
        public string Position { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }

        public DTO_User Account = new DTO_User();
        public DTO_Worker() { }

        public DTO_Worker(string lastname, string firstname, string gender, string position, string phone, DateTime bir, string email, string password)
        {
            this.Lastname = lastname;
            this.Firstname = firstname;
            this.Gender = gender;
            this.Position = position;
            this.Phone = phone;
            this.Birthdate = bir;
            Account.Email = email;
            Account.PassWord = password;
        }
    }
}
