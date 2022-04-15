using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreMVC.Data;
using GeneralStoreMVC.Models.Customer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeneralStoreMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly GeneralStoreDBContext _ctx;

        public CustomerController(GeneralStoreDBContext ctx)
        {
            _ctx = ctx;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var customers = _ctx.Customers.Select(customers => new CustomerIndexModel
            {
                Id = customers.Id,
                Name = customers.Name,
                Email = customers.Email
            });
            return View(customers);
        }
    }
}
