using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class EmployeesDetail
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="The Name is required")]
        [StringLength(50,ErrorMessage ="The name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Designation is required")]
        public string Designation { get; set; }
        [Required(ErrorMessage ="The hired date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime HireDate { get; set; }
        public char DelStatus { get; set; } = 'A';


        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual DepartmentDetails DepartmentDetails { get; set; }
    }
}
