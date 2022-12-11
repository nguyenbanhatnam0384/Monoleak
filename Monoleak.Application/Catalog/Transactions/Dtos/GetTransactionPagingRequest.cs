using Monoleak.Application.Catalog.Dtos;
using Monoleak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Transactions.Dtos
{
    public class GetTransactionPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
