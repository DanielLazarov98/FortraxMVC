using FortraxMVC.Models;
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
    }
}
