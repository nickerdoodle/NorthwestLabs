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
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }

        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Display(Name = "Compound Name")]
        public String CompName { get; set; }

        [Display(Name = "Vloume")]
        public Double? Volume { get; set; }

        [Display(Name = "Volume Unit ID")]
        public int? VolumeUnitID { get; set; }
        public virtual VolumeUnit VolumeUnit { get; set; }

        [Display(Name = "Date Arrived")]
        public DateTime? DateArrived { get; set; }

        [Display(Name = "Received By")]
        public String ReceivedBy { get; set; }

        [Display(Name = "Date Due")]
        public DateTime? DateDue { get; set; }

        [Display(Name = "Client Weight")]
        public Double? ClientWeight { get; set; }

        [Display(Name = "Weight Unit ID")]
        public virtual int? WeightUnitID { get; set; }
        public virtual WeightUnit WeightUnit { get; set; }

        [Display(Name = "Molecular Mass")]
        public Double? MolecularMass { get; set; }

        [Display(Name = "Confirmation ID")]
        public int? ConfID { get; set; }

        [Display(Name = "Actual Weight")]
        public Double? ActualWeight { get; set; }

        [Display(Name = "Max Tolerated Dose ID")]
        public int? DoseID { get; set; }
    }
}