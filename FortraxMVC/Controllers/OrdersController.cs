using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FortraxMVC.Models;
using FortraxMVC.Services;
using FortraxMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FortraxMVC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;

        public UserManager<User> _UserManager { get; }

        public OrdersController(UserManager<User> _userManager,IOrderService orderService)
        {
            _UserManager = _userManager;
            this.orderService = orderService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(string productId, int quantity)
        {
            var userId = _UserManager.GetUserId(HttpContext.User);

            var order = orderService.CreateOrder<OrderViewModel>(userId, productId, quantity);

            return View(order);
        }

        public IActionResult Details()
        {
            var userId = _UserManager.GetUserId(HttpContext.User);

            var orders = orderService.GetAllOrders<OrderViewModel>(userId);

            return View(orders);
        }
    }
}