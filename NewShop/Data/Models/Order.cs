using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public int Adress { get; set; }
        public int Phone { get; set; }
        public int Email { get; set; }
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
