namespace Vet_Pet_Api.Entities
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string StockName { get; set; }

        public int Quantity { get; set; }
    }
}
