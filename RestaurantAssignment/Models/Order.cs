using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{
    [Table(name: "Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int OrderId { get; set; }


      
       
        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(Order.CustomerId))]
        public Customer Customer { get; set; }




        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(Order.CategoryId))]
        public Category Category { get; set; }


        [Required]
        public int Quantity { get; set; }


       



    }
}
