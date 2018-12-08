using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("State")]
    public class State
    {
        [Key]
        [Display(Name = "State ID")]
        public int StateID { get; set; }

        [Display(Name = "State")]
        public String StateDesc { get; set; }

        [Display(Name = "Country ID")]
        public int CountryID { get; set; }
    }
}