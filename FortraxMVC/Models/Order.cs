using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Models
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public int Quantity { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }

        public string IssuerId { get; set; }
        public User Issuer { get; set; }
    }
}
