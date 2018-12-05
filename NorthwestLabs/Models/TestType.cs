using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestType")]
    public class TestType
    {
        [Key]
        public int TestTypeID { get; set; }

        public String TestTypeDesc { get; set; }

        public float ConcentrationNeeded { get; set; }

        public float QuantityNeeded { get; set; }

        public int UnitID { get; set; }
    }
}