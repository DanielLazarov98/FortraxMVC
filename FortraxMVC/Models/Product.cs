using FortraxMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Models
{
    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
            this.Orders = new HashSet<Order>();
        }
        public string Id { get; set; }

        public string Name { get; set; }

        public ProductType ProductType { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public string Image { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
