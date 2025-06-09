using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Management_System.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }
        
        [ForeignKey("Medicine")] 
        public int MedicineID { get; set; }
        public Medicine Medicine { get; set; }
        public DateOnly DateArrived { get; set; }
        public DateOnly DateExpiry { get; set; }
        public int CurrentStock { get; set; }
        public int QuantityRemoved { get; set; }
        public string Location { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee {get; set;}

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
