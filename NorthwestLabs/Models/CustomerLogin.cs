using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("CustomerLogin")]
    public class CustomerLogin
    {
        [Key]
        [Display(Name ="Username")]
        [Required(ErrorMessage ="Username required")]
        public String CustUserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password required")]
        public String CustPassword { get; set; }

        [Display(Name = "Last Login")]
        [Required(ErrorMessage = "Last Login required")]
        public DateTime LastLogin { get; set; }

        [Display(Name = "Last Password Change")]
        [Required(ErrorMessage = "Last Password Change required")]
        public DateTime LastPasswordChange { get; set; }

        [Display(Name ="Customer ID")]
        [Required(ErrorMessage = "Customer ID required")]
        public int CustID { get; set; }
    }
}