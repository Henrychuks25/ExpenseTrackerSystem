using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Models
{
    public class Expense
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Expense Date")]
        public DateTime ExpenseDate { get; set; }
        [DisplayName("Expense Category")]
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
