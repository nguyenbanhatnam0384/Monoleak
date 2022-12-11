using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monoleak.Application.Catalog.Categories;

namespace Monoleak.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }
    }
}
