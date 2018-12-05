using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Access")]
    public class Access
    {
        [Key]
        public int AccessID { get; set; }

        public String AccessDesc { get; set; }


    }
}