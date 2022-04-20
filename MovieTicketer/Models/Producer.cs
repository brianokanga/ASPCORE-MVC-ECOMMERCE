using MovieTicketer.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTicketer.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture Url")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "String length must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
