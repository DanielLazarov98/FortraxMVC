using FortraxMVC.Data;
using FortraxMVC.Models;
using System;
using AspNetCoreTemplate.Services.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services
{
    public class OrderService : IOrderService
    {
        private ApplicationDbContext db;

        public OrderService(ApplicationDbContext db)
        {            
           this.db = db;
            
        }
        public TViewModel CreateOrder<TViewModel>(string userId, string productId, int quantity)
        {
            var issuer = db.Users.SingleOrDefault(x => x.Id == userId);
            var product = db.Products.SingleOrDefault(x => x.Id == productId);

            var order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                IssuedOn = DateTime.UtcNow,
                Issuer = issuer,
                IssuerId = issuer.Id,
                Product = product,
                ProductId = product.Id,
                Quantity = quantity
            };

            db.Orders.Add(order);
            db.SaveChanges();

            var orderViewModel = db.Orders.Where(x => x == order).To<TViewModel>().SingleOrDefault();

            return orderViewModel;
        }

        public IEnumerable<TViewModel> GetAllOrders<TViewModel>(string userId)
        {
            var orders = db.Orders.Where(x => x.IssuerId == userId).To<TViewModel>().ToList();

            return orders;
        }
    }
}
