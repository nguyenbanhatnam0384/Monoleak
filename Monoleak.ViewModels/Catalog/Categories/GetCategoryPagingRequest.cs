using Monoleak.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.ViewModels.Catalog.Categories
{
    public class GetCategoryPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> TransactionIds { get; set; }
    }
}
