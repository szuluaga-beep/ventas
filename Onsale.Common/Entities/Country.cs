using System.ComponentModel.DataAnnotations;

namespace Onsale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The Field {0} must contain less than {1} characteres")]
        public string Name { get; set; }
    }
}
