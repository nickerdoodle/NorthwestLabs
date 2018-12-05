using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("UnitOfMeasure")]
    public class UnitOfMeasure
    {
        [Key]
        public int UnitID { get; set; }

        public String UoMDesc { get; set; }
    }
}