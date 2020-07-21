using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NewShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NewShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Product.Any())
            {
                content.AddRange(
                new Product
                {
                    Name = "Наполеон",
                    Prise = 890,
                    LongDescription = "Вспомни свой 1812",
                    ShortDescription = "Любимый пирог Панасеноква",
                    Image = "/img/napoleon.jpg",
                    Avialable = true,
                    IsFavorite = true,
                    Category = Categories["Торт"]
                },
                new Product
                {
                    Name = "Осетинский",
                    Prise = 290,
                    LongDescription = "Для хачай и Хабиба",
                    ShortDescription = "Азербайджанский",
                    Image = "/img/oset.jpg",
                    Avialable = true,
                    IsFavorite = true,
                    Category = Categories["Пирог"]
                },
                new Product
                {
                    Name = "Прага",
                    Prise = 730,
                    LongDescription = "Прексный чарующий вкус",
                    ShortDescription = "Класека",
                    Image = "/img/praga.jpg",
                    Avialable = true,
                    IsFavorite = true,
                    Category = Categories["Торт"]
                },
                new Product
                {
                    Name = "Морковный",
                    Prise = 840,
                    LongDescription = "Прексный чарующий вкус",
                    ShortDescription = "Любимый торт Мальчеза",
                    Image = "/img/morkov.jpg",
                    Avialable = true,
                    IsFavorite = true,
                    Category = Categories["Торт"]
                },
                new Product
                {
                    Name = "Лимонный торт",
                    Prise = 760,
                    LongDescription = "Прексный чарующий вкус",
                    ShortDescription = "Не хватает только Лемончеллы",
                    Image = "/img/limon.jpg",
                    Avialable = true,
                    IsFavorite = true,
                    Category = Categories["Торт"]
                },
                new Product
                {
                    Name = "Шоколадный торт",
                    Prise = 730,
                    LongDescription = "Прексный чарующий вкус",
                    ShortDescription = "Шоколадный заяц",
                    Image = "/img/choco.jpg",
                    Avialable = true,
                    IsFavorite = false,
                    Category = Categories["Торт"]
                },
                new Product
                {
                    Name = "Яблочный пирог",
                    Prise = 730,
                    LongDescription = "Прексный чарующий вкус",
                    ShortDescription = "Пахнет весной",
                    Image = "/img/apple.jpg",
                    Avialable = true,
                    IsFavorite = true,
                    Category = Categories["Пирог"]
                }
            );
                
        }
            content.SaveChanges();

    }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Пирог", Description = "Вкусный" },
                        new Category { CategoryName = "Торт", Description = "Очень вкусный" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;

            }
        }
    }
}
