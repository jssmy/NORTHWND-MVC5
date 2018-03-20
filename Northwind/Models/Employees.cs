using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    /****** cambio de prueba  ******/
    [Table(name: "Employees")]
    public class Employees
    {
        [Key]
        [Display(Name = "Codg.")]
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name ="Apellidos")]
        [StringLength(maximumLength:20)]
        public String LastName { get; set; }

        [Required]
        [Display(Name ="Nombres")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name ="Cargo")]
        [StringLength(maximumLength:30)]
        public String Title { get; set; }

        [Display(Name ="Cortesía")]
        [StringLength(maximumLength:25)]
        public String TitleOfCourtesy { get; set; }


        [Required]
        [Display(Name ="Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name ="Fecha de contrato")]
        public DateTime HireDate { get; set; }

        [Display(Name ="Dirección")]
        public String Address { get; set; }

        [Display(Name ="Ciudad")]
        [StringLength(maximumLength:15)]
        public String City { get; set; }


        [Display(Name ="Región")]
        [StringLength(maximumLength:15)]
        public String Region { get; set; }

        [Display(Name ="Codg. Postal")]
        [StringLength(maximumLength:10)]
        public String PostalCode { get; set; }

        [Display(Name ="País")]
        [StringLength(maximumLength:15)]
        public String Country { get; set; }

        [Display(Name ="Teléfono")]
        [StringLength(maximumLength:24)]
        public String HomePhone { get; set; }

        [Display(Name ="")]
        public int Extension { get; set; }

        [NotMapped]
        public String Photo { get; set; }

        [Display(Name ="Nota")]
        public String Notes { get; set; }


        [Url]
        [Display(Name ="Path foto ")]
        public String PhotoPath { get; set; }

        public int ReportsTo { get; set; }
        public Employees ReportsEmployee { get; set; }

        public ICollection<Employees> Reports { get; set;  }
    

    }
}