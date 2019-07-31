using AspNetCoreTemplate.Services.Mapping;
using FortraxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.ViewModels
{
    public class OrderViewModel : IMapFrom<Order>
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string ProductName { get; set; }

        public DateTime IssuedOn { get; set; }

        public int Quantity { get; set; }
    }
}
