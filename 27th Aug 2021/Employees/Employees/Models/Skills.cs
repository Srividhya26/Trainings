using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    [Table("Skills")]
    public class Skills
    {
        [Key]
        public int SkillId { get; set; }
        [Required]
        public string SkillName { get; set; }

        public virtual ICollection<EmployeeDetail> Details { get; set; }

       
    }
}
