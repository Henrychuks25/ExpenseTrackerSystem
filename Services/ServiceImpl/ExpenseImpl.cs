using Expense_Tracker.Context;
using Expense_Tracker.Models;
using Expense_Tracker.Models.VModels;
using Expense_Tracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Services.ServiceImpl
{
    public class ExpenseImpl : IExpense
    {

        private readonly TrackerDbContext _db;

        public ExpenseImpl(TrackerDbContext db)
        {
            _db = db;
        }

        public async Task<string> Create(ExpenseCreateVm expense)
        {
            var mgs = string.Empty;

            //check if record already exist
            if (expense.Id == Guid.Empty)
            {
                var record = await GetById(expense.Id);

            
            if (record == null)
            {
                Expense obj = new Expense();
                obj.Id = Guid.NewGuid();
                obj.Amount = expense.Amount;
                obj.CategoryId = expense.CategoryId;
                obj.ExpenseDate = expense.ExpenseDate;

                await _db.Expenses.AddAsync(obj);
                _db.SaveChanges();
                mgs = "Created successfully";
                return mgs;
            }
            else
            {
                mgs = "Record already exist";

            }

            }

            mgs = "Not Successful";

            return mgs;

        }

        public void Delete(Guid expenseId)
        {
            var result = GetById(expenseId);
            _db.Expenses.Remove(result.Result);
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Expense>> GetByCategories(Guid category)
        {
            var result = await _db.Expenses.Include(c => c.Category).Where(x => x.CategoryId == category).ToListAsync();

            return result;
        }

        public async Task<Expense> GetById(Guid id)
        {
            var result = await _db.Expenses.Where(x => x.Id == id).FirstOrDefaultAsync();
            return (result);
        }

        public async Task<IEnumerable<Expense>> List()
        {
            var result = await _db.Expenses.Include(c => c.Category).
                ToListAsync();

            return (result);
        }

        public async Task<IEnumerable<Expense>> TwoExpenses(ExpenseRangeListVm expenseRange)
        {
            Expense obj = new Expense();
            ExpenseRangeListVm objs = new ExpenseRangeListVm();

            var ExpenseDetails = await _db.Expenses.Include(s => s.Category).Where(t => t.ExpenseDate >= expenseRange.StartDate
            && t.ExpenseDate <= expenseRange.EndDate).ToListAsync();


            return (IEnumerable<Expense>)ExpenseDetails;
        }
        public int Update(ExpenseUpdateVm expense)
        {
            var getUser = _db.Expenses.Where(x => x.Id == expense.Id).FirstOrDefault();

            var mgs = "";
            if (getUser != null)
            {

                _db.Entry(getUser).CurrentValues.SetValues(expense);

                _db.SaveChanges();

                mgs = "Updated Successfully!";

            }
            else
            {
                mgs = "Error occurred";
            }




            return 1;
        }
    }
}
