using Monoleak.Application.Catalog.Dtos;
using Monoleak.Application.Catalog.Transactions.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Transactions
{
    public class TransactionService : ITransactionService
    {
        public Task<int> Create(TransactionCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int TransactionId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(TransactionEditRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransactionViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<TransactionViewModel>> GetAllPaging(GetTransactionPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
