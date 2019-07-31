using FortraxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services
{
    public interface  ILotteryService
    {        
        Ticket GetWinningTicket(string id);
    }
}
