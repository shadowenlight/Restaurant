using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    public class Food
    {
        public virtual int FoodId{get;set;}
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string FoodArtUrl { get; set; }
        public virtual Category Category { get; set; }
    }
}