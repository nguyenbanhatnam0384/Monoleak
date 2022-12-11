using Microsoft.EntityFrameworkCore;
using Monoleak.Application.Catalog.Categories.Dtos;
using Monoleak.Application.Catalog.Dtos;
using Monoleak.Data.EF;
using Monoleak.Data.Entities;
using Monoleak.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly MonoleakDbContext _context;
        public CategoryService(MonoleakDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Name = request.Name,
            };
            _context.Categories.Add(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int CategoryId)
        {
            var category = await _context.Categories.FindAsync(CategoryId);
            if (category == null) throw new MonoleakException($"Can not find a category: {CategoryId}");
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit(CategoryEditRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<CategoryViewModel>> GetAllPaging(GetCategoryPagingRequest request)
        {
            //Select join
            var query = from c in _context.Categories
                        join tic in _context.TransactionInCategories on c.Id equals tic.CategoryId
                        join t in _context.Transactions on tic.TransactionId equals t.Id
                        select new { c, tic };
            //Filter
            if (request.TransactionIds.Count > 0)
            {
                query = query.Where(c => request.TransactionIds.Contains(c.tic.TransactionId));
            }
            //Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new CategoryViewModel()
                {
                    Id = x.c.Id,
                    Name = x.c.Name
                }).ToListAsync();
            //Select and projection
            var pageResult = new PagedResult<CategoryViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pageResult;
        }
    }
}
