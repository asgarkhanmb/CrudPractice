using Fiorello_PB101.Helpers;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiorello_PB101.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArchiveController : Controller
    {
        private readonly ICategoryService _categoryService;

        public ArchiveController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

    
        public async Task<IActionResult> CategoryArchive(int page=1,int take=4)
        {
            var categories = await _categoryService.GetAllPaginateAsync(page,take);

            var mappedDatas = _categoryService.GetMapDatas(categories);

            int totalPage = await GetPageCountAsync(take);

            Paginate<CategoryArchiveVM> paginateDatas = new(mappedDatas, totalPage, page);

            return View(paginateDatas);
        }

        private async Task<int> GetPageCountAsync(int take)
        {
            int categoryCount = await _categoryService.GetCountAsync();

            return (int)Math.Ceiling((decimal)categoryCount / take);
        }
    }

}
