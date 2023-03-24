using System.ComponentModel.DataAnnotations;


namespace Lab.MVC.Models
{
    public class ShippersView
    {

        
        public int ID { get; set; }        
        
        [Required(ErrorMessage = "  Campo Requerido!")]
        public string companyName { get; set; }

        [Required(ErrorMessage = "  Campo Requerido!")]
        public string phone { get; set; }
    }
}