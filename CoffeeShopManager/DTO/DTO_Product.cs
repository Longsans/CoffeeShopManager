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
        public byte [] Image { get; set; }
        public double Price { get; set; }
        public string Detail { get; set; }
        DTO_Product (int Id,string name,string type,double money,string detail)
        {
            this.Id = Id;
            this.Name = name;
            this.Type = type;
            this.Price = money;
            this.Detail = detail;
        }
        DTO_Product(byte[] image)
        {
            this.Image = image;
        }
    }
}
