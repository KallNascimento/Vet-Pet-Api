namespace Vet_Pet_Api.Entities
{
    public class Pet:Person
    {
        public Guid Id { get; set; }
        public Breed Breed { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
