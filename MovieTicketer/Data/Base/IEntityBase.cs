using System.ComponentModel.DataAnnotations;

namespace MovieTicketer.Data.Base
{
    public interface IEntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
