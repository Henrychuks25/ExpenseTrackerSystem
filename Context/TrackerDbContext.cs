﻿using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Context
{
    public class TrackerDbContext : DbContext
    {
        public TrackerDbContext(DbContextOptions options): base(options)
        {

        }
       public  DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
