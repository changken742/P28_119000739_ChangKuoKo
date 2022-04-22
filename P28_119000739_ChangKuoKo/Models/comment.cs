using System.ComponentModel.DataAnnotations;

namespace P28_119000739_ChangKuoKo.Models
{
    public class comment
    {
        public int ID { get; set; }
        [Required]
        public string Author { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
    }
}