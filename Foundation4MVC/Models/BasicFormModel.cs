using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foundation4MVC.Models
{
    public class BasicFormModel
    {
        [Required]
        [Display(Name = "Sample")]
        public string SampleField { get; set; }

        [Required(ErrorMessage = "required")]
        [Display(Name = "Drop Down")]
        public string Selected { get; set; }

        public SelectList DropDownItems { get; set; }
    }
}
