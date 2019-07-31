using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FortraxMVC.Services;
using FortraxMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FortraxMVC.Controllers
{
    public class LotteryController : Controller
    {
        private readonly ILotteryService lotteryService;

        public LotteryController(ILotteryService lotteryService)
        {
            this.lotteryService = lotteryService;

        }
        public IActionResult Index(string lotteryId)
        {
            var winningTicket = lotteryService.GetWinningTicket(lotteryId);

            var winner = new LotteryWinnerViewModel
            {
                Winner = winningTicket.User,
                WinningTicket = winningTicket
            };

            return View(winner);
        }
    }
}