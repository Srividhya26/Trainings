using EmployeeDetails.Data;
using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly MyDbContext _db;

        public DepartmentController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<DepartmentDetails> departments = _db.Department;

            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Create(DepartmentDetails dept)
        {
            if (ModelState.IsValid)
            {
                _db.Department.Add(dept);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(dept);
        }
    }
}
