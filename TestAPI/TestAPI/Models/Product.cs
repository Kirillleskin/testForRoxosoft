using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public int Total { get; set; }

        public ICollection<OrderToProduct> OrderToProductList { get; } = new List<OrderToProduct>();
    }
}
