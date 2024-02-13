using System.ComponentModel.DataAnnotations;

namespace Vet_Pet_Api.Entities
{
    public class Breed
    {
        public Guid Id { get; set; }
        [Required]

        public string Description { get; set; }
    }
}
