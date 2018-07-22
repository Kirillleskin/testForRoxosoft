using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
	    public int Status { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }

        public ICollection<OrderToProduct> OrderToProductList { get; } = new List<OrderToProduct>();
    }
}
