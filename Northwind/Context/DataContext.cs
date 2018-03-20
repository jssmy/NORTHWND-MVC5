using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Northwind.Context
{
    public class DataContext: DbContext
    {
        public DbSet<Customers> Customer { get; set; }

        public Boolean Validate_exist (Customers customer) {
            var c = Customer.Find(customer.CustomerID);
            if (c != null) return true;
            return false;
        }

    }
}