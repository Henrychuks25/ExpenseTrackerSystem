using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Models.VModels
{
    public class VMExpenses
    {
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        public DateTime ExpenseDate { get; set; }
        public Expense Expense { get; set; }
        public string Category { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }

    }
    public class ExpenseRangeVm
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]

        [Required]
        public DateTime EndDate { get; set; }

    }

    public class ExpenseRangeListVm
    {
        [Required]
        public Expense Expense { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        [Required]
        public DateTime EndDate { get; set; }

    }
    public class ExpenseCreateVm
    {
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        [Required]
        public DateTime ExpenseDate { get; set; }

        [DisplayName("Expense Category")]
        [Required]
        public Guid CategoryId { get; set; }
        

    }
    public class MessageVm
    {
        public string Name { get; set; }
    }
    public class ExpenseUpdateVm
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        [Required]
        public DateTime ExpenseDate { get; set; }
        [DisplayName("Expense Category")]
        [Required]
        public Guid CategoryId { get; set; }
    }
}
