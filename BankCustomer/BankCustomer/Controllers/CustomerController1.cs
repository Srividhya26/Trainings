using BankCustomer.Data;
using BankCustomer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCustomer.Controllers
{
    public class CustomerController1 : Controller
    {
        private readonly MyDbContext _myDb;

        public CustomerController1(MyDbContext myDb)
        {
            _myDb = myDb;
        }
        public IActionResult Index()
        {
            IEnumerable<Customer> customerList = _myDb.Customers;

            return View(customerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer cust)
        {
            if(ModelState.IsValid)
            {
                _myDb.Customers.Add(cust);
                _myDb.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(cust);
        }
    }
}
