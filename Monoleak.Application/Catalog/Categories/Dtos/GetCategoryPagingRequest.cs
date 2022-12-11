using Monoleak.Application.Catalog.Dtos;
using Monoleak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Categories.Dtos
{
    public class GetCategoryPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> TransactionIds { get; set; }
    }
}
