using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortraxMVC.Services
{
    public interface IOrderService
    {
        TViewModel CreateOrder<TViewModel>(string userId, string productId, int quantity);

        IEnumerable<TViewModel> GetAllOrders<TViewModel>(string userId);
    }
}
