using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    public class Table
    {
        public virtual int TableId { get; set; }
        [Required(ErrorMessage ="Which table to reserve")]
        public virtual int TableNumber { get; set; }
        public virtual int MaxSeat { get; set; }
    }
}