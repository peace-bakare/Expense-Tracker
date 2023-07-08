using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //Specifying Foreign Key
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int TransactionAmount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? TransactionNote { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
