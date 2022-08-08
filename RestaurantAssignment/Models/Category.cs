using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{
    [Table(name: "Categories")]
    public class Category
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Category")]
        public string ItemCategoryName { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsAvailable { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Menu> Menus { get; set; }





    }
}
