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

        public IActionResult Update(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var cust = _myDb.Customers.FirstOrDefault(x => x.Id == id);
            if(cust == null)
            {
                return NotFound();
            }

            return View(cust);
        }

        [HttpPost]
        public IActionResult Update(Customer cust)
        {
            if(ModelState.IsValid)
            {
                _myDb.Customers.Update(cust);
                _myDb.SaveChanges();
            }

            ViewBag.Message = string.Format("The updation is successfull");

            return View(cust);
        }

        //[HttpPost]
        public IActionResult Delete(int? id)
        {
            var cust = _myDb.Customers.Find(id);

            if(cust == null)
            {
                return NotFound();
            }
            _myDb.Customers.Remove(cust);
            _myDb.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
