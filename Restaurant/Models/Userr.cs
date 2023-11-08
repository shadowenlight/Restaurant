using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Models
{
    public class Userr
    {
        public virtual int UserrId { get; set; }
        public virtual string usr { get; set; }
        public virtual string usrnm { get; set; }
        public virtual Roles Role { get; set; }
    }

    public enum Roles
    {
        Admin = 1,
        User = 2,
        Guest=3
    }
}