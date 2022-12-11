using Monoleak.Application.Catalog.Categories.Dtos;
using Monoleak.Application.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<int> Create(CategoryCreateRequest request);
        Task<int> Edit(CategoryEditRequest request);
        Task<int> Delete(int CategoryId);
        Task<List<CategoryViewModel>> GetAll();
        Task<PagedResult<CategoryViewModel>> GetAllPaging(GetCategoryPagingRequest request);
    }
}
