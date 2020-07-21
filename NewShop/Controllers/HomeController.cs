using Microsoft.AspNetCore.Mvc;
using NewShop.Data.Interfaces;
using NewShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Controllers
{
    public class HomeController : Controller
    {
        private IAllProducts _ProdRep;

        public HomeController(IAllProducts prodRep)
        {
            _ProdRep = prodRep;
        }

        public ViewResult Index()
        {
            var homeProduct = new HomeViewModel
            {
                FavProduct = _ProdRep.GetFavProducts
            };
            return View(homeProduct);
        }
    }
}
