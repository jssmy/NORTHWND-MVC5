using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Orders
    {
        [Key]
        [Display(Name ="Código")]
        public int OrderID { get; set; }

        

        [Display(Name ="Fecha de orden")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name ="Fecha máxima")]
        public DateTime RequiredDate { get; set; }

        [Required]
        [Display(Name ="Fecha de envío")]
        public DateTime ShippedDate { get; set; }

        [Required]
        [Display(Name ="Flete")]
        public Decimal Freight { get; set; }

        [Required]
        [Display(Name ="Nombre de envío")]
        [StringLength(maximumLength:40)]
        public String ShipName { get; set; }

        [Required]
        [Display(Name = "Dirección de envío")]
        [StringLength(maximumLength:60)]
        public String ShipAddress { get; set; }

        [Required]
        [Display(Name ="Ciudad destino")]
        [StringLength(maximumLength:15)]
        public String ShipCity { get; set; }

        [Required]
        [Display(Name ="Región destino")]
        [StringLength(maximumLength:15)]
        public String ShipRegion { get; set; }

        [Required]
        [Display(Name ="Codg. postal")]
        [StringLength(maximumLength:10)]
        public String ShipPostalCode { get; set; }

        [Required]
        [Display(Name ="País destino")]
        public String ShipCountry { get; set; }

        /**
         * 
         Llaves de relaciones 
         */
        
        public string CustomerID { get; set; }

        public Customers Customer { get; set; }

        public int EmployeeID { get; set; }

        public int ShipVia { get; set; }
        


    }
}