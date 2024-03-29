﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FortraxMVC.Data;
using FortraxMVC.ViewModels;
using FortraxMVC.Services.Home;
using FortraxMVC.Models.Enums;

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

            var product = this.productService.GetProductDetails<ProductDetailsViewModel>(id);


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create(string name, ProductType type, decimal price, int quantity, string image)
        {
            this.productService.CreateProduct(name, type, price, quantity, image);

            var productType = new List<SelectListItem>();

            productType.Add(new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            foreach (ProductType item in Enum.GetValues(typeof(ProductType)))
            {
                productType.Add(new SelectListItem
                {
                    Text = Enum.GetName(typeof(ProductType), item),
                    Value = item.ToString()
                });
            }

            ViewBag.ProductType1 = productType;

            return View();
        }

        public IActionResult AddStock(string id, int quantity)
        {
            this.productService.AddProductQuantity(id, quantity);

            return Redirect("Home/Index");
        }
    }
}
