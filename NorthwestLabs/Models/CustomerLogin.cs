using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("CustomerLogin")]
    public class CustomerLogin
    {
        [Key]
        public String CustUserName { get; set; }

        public String CustPassword { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? LastPasswordChange { get; set; }
    }
}