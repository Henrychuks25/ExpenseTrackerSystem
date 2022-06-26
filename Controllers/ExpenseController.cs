using Expense_Tracker.Context;
using Expense_Tracker.Models;
using Expense_Tracker.Models.VModels;
using Expense_Tracker.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpense exp;
        private readonly TrackerDbContext cats;
        public ExpenseController(IExpense _expense, TrackerDbContext category)
        {
            exp = _expense;
            cats = category;
        }
        public async Task<IActionResult> Index()
        {
            var result = await exp.List();
            foreach(var esp in result)
            {
                 HttpContext.Session.SetString("ExpenseID", esp.Id.ToString());

            }


            return View(result);
        }
        public IActionResult Create()
        {
            VMExpenses VMexpenses = new VMExpenses()
            {
                Expense = new Expense(),
                CategoryList =  cats.Categories.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            return View(VMexpenses);

        }
        public async Task<ActionResult> Edit(Guid id)
        {
            var result = await exp.GetById(id);
            ViewBag.CategoryId = result.CategoryId;

            return View(result);
        }
        [HttpPost]
        public  ActionResult Edit(ExpenseUpdateVm expense)
        {
            if (expense.CategoryId == Guid.Empty)
            {
                TempData["msg"] = "Please Select a Category";
                return RedirectToAction("Edit");
            }
            var result =  exp.Update(expense);
            if (result > 0)
            {
                TempData["updated"] = "Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExpenseCreateVm expense)
        {

            if(expense.CategoryId == Guid.Empty)
            {
                TempData["msg"] = "Please Select a Category";
                return RedirectToAction("Create");
            }
            if (ModelState.IsValid)
            {
               
                   var result = await exp.Create(expense);
                if (result.Contains("Created successfully"))
                {
                    TempData["createdMsg"] = "Created successfully";
                    return RedirectToAction("Index");
                }
                else if (result.Contains("Record already exist"))
                {
                    TempData["createdMsg"] = "Record already exist";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["createdMsg"] = "Not Successful";
                    return RedirectToAction("Index");
                }


            }
            
            return View();
        }

        public ActionResult TwoExpenses()
        {

           

            return View();
        }

      

        public async Task<ActionResult> TwoExpensesDetails(ExpenseRangeListVm expenseRange)
        {

            var result = await exp.TwoExpenses(expenseRange);
            return View(result);
        }
        public IActionResult Delete()
        {
            ViewBag.data = HttpContext.Session.GetString("ExpenseID"); ;

            return View();
        }
        [HttpPost]
        public IActionResult Delete(Guid Id)
        {
            exp.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
