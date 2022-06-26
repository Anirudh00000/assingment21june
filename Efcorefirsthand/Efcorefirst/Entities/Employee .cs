using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcorefirst.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeAddress { get; set; }
        public ICollection<EmployeEducation>? employeeEducation { get; set; }
    }
}
