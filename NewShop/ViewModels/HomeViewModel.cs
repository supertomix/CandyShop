﻿using NewShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FavProduct { get; set; }
    }
}
