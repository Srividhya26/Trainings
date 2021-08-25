using EmployeeDetails.Data;
using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDbContext _db;

        public EmployeeController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmployeesDetail> employeeList = _db.Employee.Where(x => x.DelStatus == 'A').ToList();
            return View(employeeList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> listItems = _db.Department.Select(x =>
                 new SelectListItem
                 {
                     Text = x.DepartmentName,
                     Value = x.DepartmentId.ToString()
                 });

            ViewBag.myDropDown = listItems;

            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeesDetail emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employee.Add(emp);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(emp);
        }

        public IActionResult Update(int? id)
        {
            var emp = _db.Employee.FirstOrDefault(x => x.Id == id);
            IEnumerable<SelectListItem> listItems = _db.Department.Select(x =>
                 new SelectListItem
                 {
                     Text = x.DepartmentName,
                     Value = x.DepartmentId.ToString()
                 });

            ViewBag.myDropDown = listItems;

            return View(emp);
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var emp = _db.Employee.FirstOrDefault(x => x.Id == id);
            //if (emp == null)
            //{
            //    return NotFound();
            //}

            //return View(emp);
        }

        [HttpPost]
        public IActionResult Update(EmployeesDetail emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employee.Update(emp);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
 
            return View(emp);
        }

        public IActionResult Delete(int? id)
        {
            var emp = _db.Employee.FirstOrDefault(x => x.Id == id);

            if (emp == null)
            {
                return NotFound();
            }
            _db.Employee.Remove(emp);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
