namespace Monoleak.ViewModels.Catalog.Transactions
{
    public class TransactionCreateRequest
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
    }
}
