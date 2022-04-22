using System.ComponentModel.DataAnnotations;

namespace P28_119000739_ChangKuoKo.Models
{
    public class News
    {
        public int ID { get; set; }
        [MaxLength(200)]
        [MinLength(50)]
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        [MaxLength(500)]
        [MinLength(100)]
        [Required]
        public string Content { get; set; } = string.Empty;
        
        [Required]
        public string Author { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;


    }
}