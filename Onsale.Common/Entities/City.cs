using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onsale.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The Field {0} must contain less than {1} characteres")]
        [Required]
        public string Name { get; set; }

        [NotMapped]
        [JsonIgnore]
        public int IdDepartment { get; set; }

    }
}
