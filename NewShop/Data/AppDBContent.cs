﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Data.Models;

namespace NewShop.Data
{
    public class AppDBContent :DbContext
    { 
        

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options){
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order{ get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }



    }
}
