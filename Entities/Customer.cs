using System.ComponentModel.DataAnnotations;

namespace Vet_Pet_Api.Entities
{
    public class Customer:Person
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        [Required]

        public Pet Pet { get; set; }
    }
}
