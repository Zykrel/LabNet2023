using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Lab.MVC.Models
{
    public class ShippersView
    {

        
        public int ID { get; set; }        
        
        [Required(ErrorMessage = "Campo Requerido")]
        public string companyName { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string phone { get; set; }
    }
}