using Fiorello_PB101.Models;
using Fiorello_PB101.ViewModels.Blog;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync(int? take = null);
        Task<Blog> GetByIdAsync(int id);
        Task<bool> ExistAsync(string title);
        Task CreateAsync(Blog blog);
        Task DeleteAsync(Blog blog);
        
    }
}
