using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTicketer.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture Url")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="String length must be between 3 and 50 chars")]
        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
