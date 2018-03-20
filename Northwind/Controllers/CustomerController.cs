using Northwind.Context;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private DataContext db = new DataContext();
        public ActionResult Index(int ? page=1, String  name ="")
        {


            
            var pageNumber = page ?? 1;

            ViewBag.name = name;
            ViewBag.page = pageNumber;
            if (TempData["success_message"] != null) ViewBag.message = TempData["success_message"];
            return View(db.Customer.Where(c => c.CompanyName.Contains(name) || c.ContactName.Contains(name)).OrderBy(c=>c.CustomerID).ToPagedList(pageNumber,15));
            
        }

        // GET: Customer/Details/5
        public ActionResult Details(String id)
        {
            Customers customer = db.Customer.Find(id);
            if (customer == null) return Redirect("Index");
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customers customer)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    
                    String Id = customer.CustomerID;
                    Id.Trim();
                    customer.CustomerID = Id;
                    db.Customer.Add(customer);
                    db.SaveChanges();
                    TempData["success_message"] = "Nuevo cliente agregado al registro!";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("CustomerID", "El código del cliente se encuentra registrado");
                return View(customer); ;
            }
            catch
            {
                ModelState.AddModelError("CustomerID", "El código del cliente se encuentra registrado");
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(String id)
        {
            Customers customer = db.Customer.Find(id);
            if (customer == null) return Redirect("Index");
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, Customers customer)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    Customers c = db.Customer.Find(id);
                    c.CustomerID = customer.CustomerID;
                    c.Address = customer.Address;
                    c.City = customer.City;
                    c.CompanyName = customer.CompanyName;
                    c.ContactName = customer.ContactName;
                    c.ContactTitle = customer.ContactTitle;
                    c.Country = customer.Country;
                    c.Fax = customer.Fax;
                    c.Phone = customer.Phone;
                    c.PostalCode = customer.PostalCode;
                    c.Region = customer.Region;
                    
                    db.SaveChanges();
                    TempData["success_message"] = "Se ha actualizado los datos correctamente";
                    return RedirectToAction("Index");
                }
                return View(customer);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            TempData["success_message"] = "Nuevo cliente agregado al registro!";
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
