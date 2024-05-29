using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using NuGet.Protocol.Core.Types;

namespace Fiorello_PB101.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Blog blog)
        {
            await _context.AddAsync(blog);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Blog blog)
        {
           _context.Blogs.Remove(blog);
           await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string title)
        {
            return await _context.Blogs.AnyAsync(m => m.Description.Trim() == title.Trim());
        }

        public async Task<IEnumerable<BlogVM>> GetAllAsync(int? take = null)
        {
            IEnumerable<Blog> blogs;

            if ( take is null) 
            {
                 blogs= await _context.Blogs.ToListAsync();
            }
            else
            {
                 blogs = await _context.Blogs.Take((int)take).ToListAsync();
            }

            return blogs.Select(m=> new BlogVM { 
                Id=m.Id, 
                Title=m.Title,
                Description=m.Description,
                Image=m.Image,
                CreatedDate=m.CreatedDate.ToString("MM.dd.yyyy")})
                                         .OrderByDescending(m=>m.Id);

        }
        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Blogs.FindAsync(id);
        }
    }
}






