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
        public int MaterialID { get; set; }

        [Key]
        public int TestTypeID { get; set; }

        public Double AmountRequired { get; set; }

        public int UnitID { get; set; }
    }
}