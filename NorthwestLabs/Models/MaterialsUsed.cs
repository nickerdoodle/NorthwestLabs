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
        [Display(Name = "Material ID")]
        public virtual int MaterialID { get; set; }
        public virtual ICollection<Material> Materials { get; set; }

        [Key]
        [Display(Name = "Test Instance")]
        public virtual int TestInstanceID { get; set; }
        public virtual ICollection<TestInstance> TestInstances { get; set; }

        [Display(Name = "Amount Consumed")]
        public Double AmountConsumed { get; set; }

        [Display(Name = "Unit ID")]
        public int UnitID { get; set; }
    }
}