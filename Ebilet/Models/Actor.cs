using System.ComponentModel.DataAnnotations;

namespace Ebilet.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile Picture")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string? FullName { get; set; }
        [Display(Name = "Bioghraphy")]
        public string? Bio { get; set; }
        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
