using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FortraxMVC.Models;
using Microsoft.AspNetCore.Authorization;
using FortraxMVC.Services.Home;
using FortraxMVC.ViewModels;
using AutoMapper;

namespace FortraxMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        

        public HomeController(IProductService productService)
        {
            this.productService = productService;
           
        }

           
        public IActionResult Index()
        {      
            var products = this.productService.GetAllProducts<HomeViewModel>();
                            

            return this.View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
