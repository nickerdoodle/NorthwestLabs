using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using NorthwestLabs.Models;

namespace NorthwestLabs.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        public int LTNumber { get; set; }

        public int OrderID { get; set; }

        public String CompName { get; set; }

        public Double? Volume { get; set; }

        public int? VolumeUnitID { get; set; }

        public DateTime? DateArrived { get; set; }

        public String ReceivedBy { get; set; }

        public DateTime? DateDue { get; set; }

        public Double? ClientWeight { get; set; }

        public virtual int? ClientWeightUnitID { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        public Double? MolecularMass { get; set; }

        public int? ConfID { get; set; }

        public Double? ActualWeight { get; set; }

        public int? ActualWeightUnitID { get; set; }

        public int? DoseID { get; set; }
    }
}