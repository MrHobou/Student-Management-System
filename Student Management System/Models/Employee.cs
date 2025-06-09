using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public char MI { get; set; }
        public string Position { get; set; }
        public string UserName {get; set;}

        public string Password { get; set; }
    }
}
