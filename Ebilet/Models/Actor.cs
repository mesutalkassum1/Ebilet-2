using System.ComponentModel.DataAnnotations;

namespace Ebilet.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
