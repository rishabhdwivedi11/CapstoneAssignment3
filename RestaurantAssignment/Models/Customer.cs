using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{
    [Table(name: "Customers")]
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Customer ")]
        public string CustomerName { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
