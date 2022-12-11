using Microsoft.EntityFrameworkCore;

using Monoleak.Data.EF;
using Monoleak.Data.Entities;
using Monoleak.Utilities.Exceptions;
using Monoleak.ViewModels.Catalog.Transactions;
using Monoleak.ViewModels.Common;

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
                Amount = request.Amount,
                CreatedDate = DateTime.Now,
                Description = request.Description,
            };
            _context.Transactions.Add(transaction);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int TransactionId)
        {
            var transaction = await _context.Transactions.FindAsync(TransactionId);
            if (transaction == null) throw new MonoleakException($"Can not find a transaction: {TransactionId}");
            _context.Transactions.Remove(transaction);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit(TransactionEditRequest request)
        {
            var transaction = await _context.Transactions.FindAsync(request.Id);

            if (transaction == null) throw new MonoleakException($"Cannot find a transaction with id: {request.Id}");

            transaction.Description = request.Description;
            transaction.Name = request.Name;
            transaction.Amount = request.Amount;

            return await _context.SaveChangesAsync();
        }

        public Task<List<TransactionViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<TransactionViewModel>> GetAllPaging(GetTransactionPagingRequest request)
        {
            //Select join
            var query = from t in _context.Transactions
                        join tic in _context.TransactionInCategories on t.Id equals tic.TransactionId
                        join c in _context.Categories on tic.CategoryId equals c.Id
                        select new { t, tic };
            //Filter
            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(t => request.CategoryIds.Contains(t.tic.CategoryId));
            }
            //Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new TransactionViewModel()
                {
                    Id = x.t.Id,
                    Name = x.t.Name,
                    Amount = x.t.Amount,
                    CreatedDate = x.t.CreatedDate,
                    Description = x.t.Description,
                }).ToListAsync();
            //Select and projection
            var pageResult = new PagedResult<TransactionViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pageResult;
        }
    }
}