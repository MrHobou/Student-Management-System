using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Management_System.Models
{
    public class TransactionDetail
    {
        [Key]
        public int TransDetailID { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public double EnterCash { get; set; }

        [ForeignKey("Transaction")]
        public int TransactionID { get; set; }
        public Transaction? Transaction { get; set; }
    }
}
