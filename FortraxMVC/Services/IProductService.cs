using FortraxMVC.Models;
using FortraxMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services.Home
{
    public interface IProductService
    {
        IEnumerable<TViewModel> GetAllProducts<TViewModel>();
        TViewModel  GetProductDetails<TViewModel>(string id);

        void CreateProduct(string name, ProductType type, decimal price, int inStock, string image);
       

        void AddProductQuantity(string productId, int quantity);
       
    }
}
