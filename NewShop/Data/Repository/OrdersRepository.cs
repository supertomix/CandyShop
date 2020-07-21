using NewShop.Data.Interfaces;
using NewShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var OrderDetail = new OrderDetail()
                {
                    ProductId = el.product.Id,
                    OrderId = order.Id,
                    Price = el.product.Prise
                };
                appDBContent.OrderDetail.Add(OrderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
