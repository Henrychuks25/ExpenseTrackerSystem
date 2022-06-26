using Expense_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Services.Interfaces
{
  public  interface ICategory
    {
        Task<IEnumerable<Category>> List();

        Task<Category> GetById(Guid id);

        string Create(Category category);
        int Update(Category category);

        void Delete(Guid categoryId);
    }
}
