using Expense_Tracker.Context;
using Expense_Tracker.Models;
using Expense_Tracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Services.ServiceImpl
{
    public class CategoryImpl : ICategory
    {

        private readonly TrackerDbContext _db;

        public CategoryImpl(TrackerDbContext db)
        {
            _db = db;
        }

        public string Create(Category category)
        {
            var mgs = string.Empty;

            //check if record already exist
            if (category.Id != Guid.Empty)
            {
                var record = GetById(category.Id);


                if (record == null)
                {
                    _db.Categories.Add(category);
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

        public void Delete(Guid categoryId)
        {
            var result = GetById(categoryId);
            _db.Categories.Remove(result.Result);
            _db.SaveChanges();
        }

       

        public async Task<Category> GetById(Guid id)
        {
            var result = await _db.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            return (result);
        }

        public async Task<IEnumerable<Category>> List()
        {
            var result = await _db.Categories.ToListAsync();

            return (result);
        }

        public int Update(Category category)
        {
            _db.Entry(category).State = EntityState.Modified;
            _db.SaveChanges();
            return 1;
        }
    }
}
