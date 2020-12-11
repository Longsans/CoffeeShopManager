using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Manager : DTO_Worker
    {
        public List<DTO_Employee> ls = new List<DTO_Employee>();

        public DTO_Manager()
        {

        }

        public DTO_Manager(DTO_Worker dtoWr)
        {
            this.Id = dtoWr.Id;
            this.Firstname = dtoWr.Firstname;
            this.Lastname = dtoWr.Lastname;
            this.Gender = dtoWr.Gender;
            this.Position = dtoWr.Position;
            this.Phone = dtoWr.Phone;
            this.Email = dtoWr.Email;
            this.Birthdate = dtoWr.Birthdate;
            this.Image = dtoWr.Image;
            this.Shop.ID = dtoWr.Shop.ID;
        }
    }
}
