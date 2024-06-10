using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class Articale
    {
        public int ArticaleId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        //külső kulcs meghatározása
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
