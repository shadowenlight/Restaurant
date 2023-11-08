using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}