using System.ComponentModel.DataAnnotations;

namespace mission6EmilyPeterson.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

    }
}
