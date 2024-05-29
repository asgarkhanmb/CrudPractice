using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Blog;
using Fiorello_PB101.ViewModels.Expert;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class ExpertService : IExpertService
    {
        private readonly AppDbContext _context;
        public ExpertService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ExpertVM>> GetAllAsync()
        {
            IEnumerable<Expert> experts = await _context.Experts.ToListAsync();

            return experts.Select(m => new ExpertVM { Name = m.Name,Image= m.Image, Position = m.Position});
        }
    }
}
