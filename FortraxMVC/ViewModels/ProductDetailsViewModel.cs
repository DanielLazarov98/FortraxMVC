using AspNetCoreTemplate.Services.Mapping;
using FortraxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.ViewModels
{
    public class ProductDetailsViewModel : IMapFrom<Product>
    {
        public ProductDetailsViewModel()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public byte[] Image { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
