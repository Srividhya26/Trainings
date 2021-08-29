using Employees.Data;
using Employees.Models;
using Employees.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    public class FrontpageController : Controller
    {
        private readonly MyDbContext _db;
        private readonly UserManager<EmployeeUser> _userManager;
        private readonly SignInManager<EmployeeUser> _signInManager;

        public FrontpageController(MyDbContext db, UserManager<EmployeeUser> user, SignInManager<EmployeeUser> signIn)
        {
            _db = db;
            _userManager = user;
            _signInManager = signIn;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if (user != null)
                {
                    var result =
                        await _signInManager.PasswordSignInAsync
                        (user.Email, login.Password, login.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Frontpage");
                    }

                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(login);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new EmployeeUser
                {
                    UserName = model.Name,
                    Email = model.Email,
                    EmailConfirmed = true

                };

                var userObj = await _userManager.FindByEmailAsync(model.Email);
                if (userObj == null)
                {
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Employee");

                        return RedirectToAction("Index", "Home");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Frontpage");
        }

        public IActionResult Index()
        {
            IEnumerable<EmployeeDetail> empList = _db.employee;

            return View(empList);
        }


        public IActionResult Create()
        {

            IEnumerable<SelectListItem> listItems = _db.skill.Select(x =>
                 new SelectListItem
                 {
                     Text = x.SkillName,
                     Value = x.SkillId.ToString()
                 });

            ViewBag.myDropDown = listItems;

            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDetail emp)
        {
            if (ModelState.IsValid)
            {
                _db.employee.Add(emp);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(emp);
        }

        public IActionResult Update(int? id)
        {
            var emp = _db.employee.FirstOrDefault(x => x.SkillId == id);
            IEnumerable<SelectListItem> listItems = _db.skill.Select(x =>
                 new SelectListItem
                 {
                     Text = x.SkillName,
                     Value = x.SkillId.ToString()
                 });

            ViewBag.myDropDown = listItems;

            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(EmployeeDetail emp)
        {
            if (ModelState.IsValid)
            {
                _db.employee.Update(emp);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(emp);
        }

        public IActionResult Delete(int? id)
        {
            var emp = _db.employee.FirstOrDefault(x => x.Id == id);

            if (emp == null)
            {
                return NotFound();
            }
            _db.employee.Remove(emp);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
