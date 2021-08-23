using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankCustomer.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,ErrorMessage ="Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Age is required")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage ="Minimum balance is required")]
        public double OpeningBalance { get; set; }

    }
}
