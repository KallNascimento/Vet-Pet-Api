using System.ComponentModel.DataAnnotations;

namespace Vet_Pet_Api.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public SubCategory SubCategory { get; set; }
    }
}
