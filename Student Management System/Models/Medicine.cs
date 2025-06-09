using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Management_System.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedicineID { get; set; }
        [ForeignKey("TransactionDetail")]
        public int TransDetailID { get; set; }
        public TransactionDetail TransactionDetail { get; set; }
        public string BrandName { get; set; }
        public string GenericName { get; set; }
        public string Unit { get; set; }
        public string UsedFor { get; set; }
        public double BuyPrice { get; set; }
        public double PriceEach { get; set; } 
    }
}
