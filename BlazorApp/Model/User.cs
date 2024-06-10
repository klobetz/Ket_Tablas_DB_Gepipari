using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MaxLength (50)]
        public string? UserName { get; set; }
        [MaxLength (100)]
        public string? Email { get; set; }

        //kapcsolat a másik táblához: egy felhasználónak több cikke is lehet
        public ICollection<Articale> Articales { get; set; }
    }
}
