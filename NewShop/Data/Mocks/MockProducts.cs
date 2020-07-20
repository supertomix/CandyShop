using NewShop.Data.Interfaces;
using NewShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _CategoryProducts = new MockCategory();
        public IEnumerable<Product> Products {
            get
            {
                return new List<Product>
                {
                    new Product {  
                         Name = "Наполеон", 
                         Prise = 890,  
                         LongDescription = "Вспомни свой 1812", 
                         ShortDescription = "Любимый пирог Панасеноква", 
                         Image = "/img/napoleon.jpg" ,
                         Avialable = true, 
                         IsFavorite = true, 
                         Category = _CategoryProducts.AllCategories.First() 
                    },
                    new Product {
                         Name = "Осетинский",
                         Prise = 290,
                         LongDescription = "Для хачай и Хабиба",
                         ShortDescription = "Для хачей",
                         Image = "/img/oset.jpg" , 
                         Avialable = true,
                         IsFavorite = true,
                         Category = _CategoryProducts.AllCategories.Last()
                    },
                    new Product {
                         Name = "Прага",
                         Prise = 730,
                         LongDescription = "Прексный чарующий вкус",
                         ShortDescription = "Класека",
                         Image = "/img/praga.jpg", 
                         Avialable = true,
                         IsFavorite = true,
                         Category = _CategoryProducts.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetProduct(int ProductID)
        {
            throw new NotImplementedException();
        }
    }
}
