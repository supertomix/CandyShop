using Microsoft.AspNetCore.Mvc;
using NewShop.Data.Interfaces;
using NewShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Controllers
{
    public class ProductsController: Controller
    {
        private readonly IAllProducts _AllProducts;
        private readonly IProductsCategory _IProductsCategory;

        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductsCategory)
        {
            _AllProducts = iAllProducts;
            _IProductsCategory = iProductsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Tittle = "Cтраница с пирогами";
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.AllProducts = _AllProducts.Products;
            obj.curCategory = "То шо есть";
            return View(obj);
        }

    }
}
