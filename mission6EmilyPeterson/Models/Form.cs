using System.ComponentModel.DataAnnotations;

namespace mission6EmilyPeterson.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string DirectorFirst { get; set; }
        [Required]
        public string DirectorLast { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool ? Edited { get; set; }
        public string ? Lent { get; set; }
        public string ? Notes { get; set; }
    }
}
