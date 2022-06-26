using Expense_Tracker.Models;
using Expense_Tracker.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Services.Interfaces
{
  public  interface IExpense
    {
        Task<IEnumerable<Expense>> List();

        Task<Expense> GetById(Guid id);

        Task<string> Create(ExpenseCreateVm expense);
        Task<IEnumerable<Expense>> GetByCategories(Guid category);
        int Update(ExpenseUpdateVm expense);

        void Delete(Guid expenseId);
        Task<IEnumerable<Expense>> TwoExpenses(ExpenseRangeListVm expenseRange);
    }
}
