namespace CodingTest.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Amount { get; set; }
    }
}
