using System.ComponentModel.DataAnnotations;

namespace Vet_Pet_Api.Entities
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        [Required]

        public string SubCategoryName { get; set; }
        public Guid CategoryId { get; set; }
        [Required]

        public Category Category { get; set; }
    }
}
