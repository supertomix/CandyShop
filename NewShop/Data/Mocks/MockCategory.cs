using NewShop.Data.Interfaces;
using NewShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Пирог", Description = "Вкусный" },
                    new Category { CategoryName = "Торт", Description = "Очень вкусный" }
                };
            }
        }    
    }
}
