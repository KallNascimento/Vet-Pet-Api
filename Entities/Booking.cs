namespace Vet_Pet_Api.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Customer CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
