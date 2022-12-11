using Monoleak.ViewModels.Catalog.Transactions;
using Monoleak.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Transactions
{
    public interface ITransactionService
    {
        Task<int> Create(TransactionCreateRequest request);
        Task<int> Edit(TransactionEditRequest request);
        Task<int> Delete(int TransactionId);
        Task<List<TransactionViewModel>> GetAll();
        Task<PagedResult<TransactionViewModel>> GetAllPaging(GetTransactionPagingRequest request);
    }
}
