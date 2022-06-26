using Expense_Tracker.Models;
using Expense_Tracker.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory category;

        public CategoryController(ICategory _category)
        {
            category = _category;
        }

        // GET: CategoryController
     
        public async Task<IActionResult> Index()
        {
            var result = await category.List();
            return View(result);
        }


        // GET: CategoryController

        public async Task<IActionResult> All()
        {
            var result = await category.List();
            return Json(result);
        }
        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category cats)
        {
            try
            {
                 category.Create(cats);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var result = category.GetById(id);
            return View(result);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
