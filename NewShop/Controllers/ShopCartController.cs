using Microsoft.AspNetCore.Mvc;
using NewShop.Data.Interfaces;
using NewShop.Data.Models;
using NewShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllProducts _ProdRep;
        private readonly ShopCart _ShopCart;

        public ShopCartController(IAllProducts prodRep, ShopCart shopCart)
        {
            _ProdRep = prodRep;
            _ShopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _ShopCart.getShopItems();
            _ShopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _ShopCart
            };
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _ProdRep.Products.FirstOrDefault(i => i.Id ==id );
            if(item != null)
            {
                _ShopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
