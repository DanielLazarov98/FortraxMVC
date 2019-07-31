using AspNetCoreTemplate.Services.Mapping;
using FortraxMVC.Data;
using FortraxMVC.Models;
using FortraxMVC.Services.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext db;        

        public ProductService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<TViewModel> GetAllProducts<TViewModel>()
        {
            var products = db.Products
                .To<TViewModel>()
                .ToList();

            return products;
        }

        public TViewModel GetProductDetails<TViewModel>(string id)
        {
            var product = db.Products
                            .Where(x => x.Id == id)
                            .To<TViewModel>()
                            .SingleOrDefault();

            return product;                           
                            
        }
    }
}
