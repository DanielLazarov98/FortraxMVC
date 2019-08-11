using AspNetCoreTemplate.Services.Mapping;
using FortraxMVC.Data;
using FortraxMVC.Models;
using FortraxMVC.Models.Enums;
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

        public void CreateProduct(string name, ProductType type, decimal price, int quantity, string image)
        {
            db.Products.Add(new Product
            {
                Name = name,
                Type = type,
                Price = price,
                InStock = quantity,
                Image = image
            });

            db.SaveChanges();
        }

        public void AddProductQuantity(string productId, int quantity)
        {
            var product = db.Products.Find(productId);

            if (product == null)
            {
                throw new NullReferenceException("There is no such product in the shop!");
            }

            int newQuantity = product.InStock + quantity;


            this.db.Products.Find(productId).InStock = newQuantity;

            db.SaveChanges();
        }
    }
}
