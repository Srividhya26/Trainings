using EmployeeDetails.Data;
using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Index(string searchText,string sortOrder)
        {
            ViewData["NameSortParam"] = sortOrder == "Name" ? "name_desc" : "name_asc";
            ViewData["DesignationSortParam"] = sortOrder == "Designation" ? "design_desc" : "design_asc";
            ViewData["DateSortParam"] = sortOrder == "HireDate" ? "date_desc" : "date_asc";
            ViewData["CurrentSearch"] = searchText;

            var employee = from EmployeesDetail in _db.Employee select EmployeesDetail;
            if (!string.IsNullOrEmpty(searchText))
            {
                employee = employee.Where(x => x.Name.ToLower().Contains(searchText.ToLower()));
            }

            //IEnumerable<EmployeesDetail> list = _db.Employee.Where(x => x.DelStatus == 'A').ToList();

            switch (sortOrder)
            {
                case "name_asc":
                    employee = employee.OrderBy(x => x.Name);
                    break;

                case "name_desc":
                    employee = employee.OrderByDescending(x => x.Name);
                    break;
                case "design_asc":
                    employee = employee.OrderBy(x => x.Designation);
                    break;
                case "design_desc":
                    employee = employee.OrderByDescending(x => x.Designation);
                    break;
                case "date_asc":
                    employee = employee.OrderBy(x => x.HireDate);
                    break;
                case "date_desc":
                    employee = employee.OrderByDescending(x => x.HireDate);
                    break;
                default:
                    employee = employee.OrderBy(x => x.Id);
                    break;

            }
            return View(employee.ToList());

            

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
