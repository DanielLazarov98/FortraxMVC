using FortraxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.ViewModels
{
    public class LotteryWinnerViewModel
    {
        public string Id { get; set; }

        public User Winner { get; set; }

        public Ticket WinningTicket { get; set; }
    }
}
