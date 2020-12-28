using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Image { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public bool Deleted { get; set; }

        public DTO_Shop Shop = new DTO_Shop();

        public DTO_Product()
        {

        }

        public DTO_Product (int Id,string name,string type,decimal money,string detail)
        {
            this.Id = Id;
            this.Name = name;
            this.Type = type;
            this.Price = money;
            this.Details = detail;
        }
        public DTO_Product(byte[] image)
        {
            this.Image = image;
        }
    }
}
