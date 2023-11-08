using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    public class Reservation
    {
        public virtual int ReservationId { get; set; }

        [DisplayName("Table")]
        public virtual int TableId { get; set; }
        public virtual int UserrId { get; set; }
        
        [DisplayName("Person")]
        [Range(1, 6)]
        public virtual int NumberOfPerson { get; set; }

        [DisplayName("Reservation Date")]
        [Required(ErrorMessage = "Enter a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Enter a time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh-mm}", ApplyFormatInEditMode = true)]
        public virtual DateTime Time { get; set; }
        public virtual Table Table { get; set; }
        //public virtual string Usr { get; set; }
        public virtual Userr userr { get; set; }
    }
}