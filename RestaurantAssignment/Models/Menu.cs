using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{
    [Table(name: "Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MenuId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Dish Name")]
        public string DishName { get; set; }

        [Required]
        public int Price { get; set; }

        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(Menu.CategoryId))]
        public Category Category { get; set; }


        


    }
}
