using Microsoft.EntityFrameworkCore;
using NewShop.Data.Interfaces;
using NewShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Product> Products => appDBContent.Product.Include(c => c.Category);

        public IEnumerable<Product> GetFavProducts => appDBContent.Product.Where(p => p.IsFavorite).Include(c => c.Category);

        public Product GetProduct(int ProductID) => appDBContent.Product.FirstOrDefault(p => p.Id == ProductID);
    }
}
