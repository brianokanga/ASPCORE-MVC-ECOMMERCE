using System.ComponentModel.DataAnnotations;

namespace MovieTicketer.Models
{
    public class Producers
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
