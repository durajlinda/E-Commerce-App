using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [Display(Name="Category Name")]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
