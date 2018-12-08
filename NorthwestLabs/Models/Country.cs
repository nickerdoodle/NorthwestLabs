using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        [Display(Name = "Country ID")]
        public int CountryID { get; set; }

        [Display(Name = "Country")]
        public String CountryDesc { get; set; }
    }
}