using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //showing a table of customers
        public ActionResult Index()
        {

            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

            return View(customers);
        }


        //show details of a single customer
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customers == null)
                return HttpNotFound();

            return View(customers);
        }

        //GET customers
        //public IEnumerable<Customer> GetCustomers()
        //{

        //    return new List<Customer>()
        //    {
        //        new Customer(){Id=1,Name="paaul"},
        //        new Customer(){Id=2,Name="shaun"},
        //        new Customer(){Id=3,Name="nick"},
        //    };
        //}
    }
}