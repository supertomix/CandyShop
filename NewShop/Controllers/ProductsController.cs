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
    public class ProductsController: Controller
    {
        private readonly IAllProducts _AllProducts;
        private readonly IProductsCategory _IProductsCategory;

        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductsCategory)
        {
            _AllProducts = iAllProducts;
            _IProductsCategory = iProductsCategory;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null ;
            string curCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                products = _AllProducts.Products.OrderBy(i => i.Id);
            }
            else
            {
                if(string.Equals("Tort", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _AllProducts.Products.Where(i => i.Category.CategoryName.Equals("Торт")).OrderBy(i=>i.Id);
                    curCategory = "Торт";
                }
                else if(string.Equals("Pirog", category, StringComparison.OrdinalIgnoreCase)){
                    products = _AllProducts.Products.Where(i => i.Category.CategoryName.Equals("Пирог")).OrderBy(i => i.Id);
                    curCategory = "Пирог";
                }
            }

            var prodObj = new ProductsListViewModel
            {
                AllProducts = products,
                curCategory = curCategory
            };

            ViewBag.Tittle = "Cтраница с пирогами";

            return View(prodObj);
        }

    }
}
