using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        public int LTNumber { get; set; }

        public int OrderID { get; set; }

        public String CompName { get; set; }

        public float? Volume { get; set; }

        public int? VolumeUnitID { get; set; }

        public DateTime? DateArrived { get; set; }

        public String ReceivedBy { get; set; }

        public DateTime? DateDue { get; set; }

        public float? ClientWeight { get; set; }

        public float? MolecularMass { get; set; }

        public int? ConfID { get; set; }

        public float? ActualWeight { get; set; }

        public int? ActualWeightID { get; set; }

        public int? DoseID { get; set; }
    }
}