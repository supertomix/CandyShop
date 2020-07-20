using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Data.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string ShortDescription { set; get; }
        public string LongDescription { set; get; }
        public string Image{ set; get; }
        public decimal Prise { set; get; }
        public bool IsFavorite { set; get; }
        
        public bool Avialable { set; get; }
        public int CategoryID { set; get; }
        public Category Category { set; get; }
    }
}
