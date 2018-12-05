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
        public int CountryID { get; set; }

        public String CountryDesc { get; set; }
    }
}