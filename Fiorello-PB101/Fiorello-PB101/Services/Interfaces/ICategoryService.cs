using Fiorello_PB101.Models;
using Fiorello_PB101.ViewModels.Categories;
using Fiorello_PB101.ViewModels.Products;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetAllPaginateAsync(int page, int take);
        Task<IEnumerable<CategoryProductVM>> GetAllWithProductCountAsync();
        Task<Category> GetByIdAsync(int id);
        Task<bool> ExistAsync(string name);
        Task CreateAsync(Category category);
        Task DeleteAsync(Category category);
        Task<bool> ExistExceptByIdAsync(int id, string name);
        Task<IEnumerable<CategoryArchiveVM>> GetAllArchiveAsync();
        Task<int> GetCountAsync();
        IEnumerable<CategoryProductVM> GetMappedDatas(IEnumerable<Category> categories);
        IEnumerable<CategoryArchiveVM> GetMapDatas(IEnumerable<Category> categories);

        Task<SelectList> GetAllSelectedAsync();
    }
}
