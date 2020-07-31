using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManager.Mvc.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private AppDbContext db = null;
        public EmployeeManagerController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult List()
        {
            List<Employee> model =
                (from e in this.db.Employees
                 orderby e.EmployeeID
                 select e).ToList();
            return View(model);
        }

        private void FillCountries()
        {
            var countries =
                (from c in db.Countries
                 orderby c.Name ascending
                 select new SelectListItem()
                 {
                     Text = c.Name,
                     Value = c.CountryID.ToString()
                 }
                 ).ToList();
            ViewBag.Countries = countries;
        }

        
    }
}
