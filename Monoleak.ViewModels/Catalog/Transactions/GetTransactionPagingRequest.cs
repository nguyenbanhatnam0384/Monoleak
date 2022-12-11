using Monoleak.ViewModels.Common;

namespace Monoleak.ViewModels.Catalog.Transactions
{
    public class GetTransactionPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
