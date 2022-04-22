using System.ComponentModel.DataAnnotations;

namespace P28_119000739_ChangKuoKo.Models
{
    public class Category
    {
        public int ID { get; set; }
        
        [MaxLength(200)]
        [Required]
        public string Name { get; set; } = string.Empty;
        
    }
}