using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("MaterialsUsed")]
    public class MaterialsUsed
    {
        [Key]
        public virtual int MaterialID { get; set; }
        public virtual ICollection<Material> Materials { get; set; }

        [Key]
        public virtual int TestInstanceID { get; set; }
        public virtual ICollection<TestInstance> TestInstances { get; set; }


        public Double AmountConsumed { get; set; }

        public int UnitID { get; set; }
    }
}