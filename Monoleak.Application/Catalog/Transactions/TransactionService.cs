using Monoleak.Application.Catalog.Dtos;
using Monoleak.Application.Catalog.Transactions.Dtos;
using Monoleak.Data.EF;
using Monoleak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Transactions
{
    public class TransactionService : ITransactionService
    {
        private readonly MonoleakDbContext _context;
        public TransactionService(MonoleakDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(TransactionCreateRequest request)
        {
            var transaction = new Transaction()
            {
                Name = request.Name,
            };
            _context.Categories.Add(transaction);
            return await _context.SaveChangesAsync();
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
