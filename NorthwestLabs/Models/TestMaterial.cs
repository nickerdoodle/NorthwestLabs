using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestMaterial")]
    public class TestMaterial
    {
        [Key]
        [Display(Name = "Material ID")]
        public int MaterialID { get; set; }

        [Key]
        [Display(Name = "Test Type ID")]
        public int TestTypeID { get; set; }

        [Display(Name = "Amount Required")]
        public Double AmountRequired { get; set; }

        [Display(Name = "Unit ID")]
        public int UnitID { get; set; }
    }
}