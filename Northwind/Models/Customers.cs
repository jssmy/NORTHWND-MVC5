using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    
    public class Customers
    {

        [Key]
        [Required]
        [Display(Name = "Codigo")]
        [Index(IsUnique =true)]
        [MinLength(3,ErrorMessage ="Mayor a 3 dígitos")]
        public String CustomerID { get; set; }

        [Required]
        [Display(Name = "Nombre de Compañía")]
        public String CompanyName { get; set; }

        [Required]
        [Display(Name = "Nombre de Contacto")]
        public String ContactName { get; set; }

        [Required]
        [Display(Name = "Título de Contacto")]
        public String ContactTitle { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        public String Address { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        public String City { get; set; }

        [Required]
        [Display(Name = "Región")]
        public String Region { get; set; }

        [Required]
        [Display(Name = "Código Postal")]
        public String PostalCode { get; set; }

        [Required]
        [Display(Name = "País")]
        public String Country { get; set; }

        [Required]
        [MaxLength(9)]
        [Display(Name = "Teléfono")]
        public String Phone { get; set; }

        [Required]
        [MaxLength(length: 11, ErrorMessage = "Este campo requiere de 11 dígitos")]
        [Display(Name = "Fax")]
        public String Fax { get; set; }

        [NotMapped]
        [Display(Name = "Dirección/Ciudad/País")]
        public String FullAddres => Address + "," + City + "," + Country;

        public virtual ICollection<Orders> Orders { get; set; }


    }
}

