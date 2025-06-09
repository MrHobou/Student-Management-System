using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Management_System.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        public DateOnly TransDate { get; set; }
        public string? PaymentMethod { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }

    }
}
