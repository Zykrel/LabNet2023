using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Lab.MVC.Models
{
    public class ShippersView
    {

        public int ID { get; set; } = 0;

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(40)]
        public string companyName { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(24)]
        public string phone { get; set; }
    }
}