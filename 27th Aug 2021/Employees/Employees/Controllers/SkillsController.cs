using Employees.Data;
using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    public class SkillsController : Controller
    {
        private readonly MyDbContext _db;

        public SkillsController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Skills> skill = _db.skill;

            return View(skill);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Skills skill)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.skill.Add(skill);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            
            catch
            {
                ViewBag.Duplicate = skill.SkillName + " skill already exists";
            }

            return View(skill);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = _db.skill.FirstOrDefault(x => x.SkillId == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        [HttpPost]
        public IActionResult Update(Skills skill)
        {
            if (ModelState.IsValid)
            {
                _db.skill.Update(skill);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(skill);
        }


        public IActionResult Delete(int? id)
        {
            var skill = _db.skill.FirstOrDefault(x => x.SkillId == id);

            if (skill == null)
            {
                return NotFound();
            }
            _db.skill.Remove(skill);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
