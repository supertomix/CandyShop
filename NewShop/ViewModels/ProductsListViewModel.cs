using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Data.Models;

namespace NewShop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable  <Product> AllProducts { get;  set; }
        public string curCategory { get; set;}
    }
}
