using Monoleak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Transactions.Dtos
{
    public class GetTransactionPagingRequest
    {
        public string Keyword { get; set; }
        public List<TransactionInCategory> TransactionInCategories { get; set; }
    }
}
