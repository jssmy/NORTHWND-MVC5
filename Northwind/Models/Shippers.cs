using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Shippers
    {
        [Key]
        [Display(Name ="Codg.")]
        public int ShipperID { get; set; }

        [Required(ErrorMessage ="Es obligatorio el nombre de la compañía")]
        [StringLength(maximumLength:40)]
        public String CompanyName { get; set; }

        [Required(ErrorMessage ="El obligatorio que ingrese el número de contacto")]
        [StringLength(maximumLength:24)]
        public String Phone { get; set; }

        public ICollection<Orders> Orders { get; set; }

    }
}