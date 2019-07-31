using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FortraxMVC.Data;
using FortraxMVC.ViewModels;
using FortraxMVC.Services.Home;

namespace FortraxMVC.Controllers
{
    public class ProductsController : Controller
    {       
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
            
        }     
        
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  this.productService.GetProductDetails<ProductDetailsViewModel>(id);
            
                
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }        
    }
}
