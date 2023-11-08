using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual int FoodId { get; set; }
        public virtual decimal Total { get; set; }
        public virtual Food Food { get; set; }
    }
}