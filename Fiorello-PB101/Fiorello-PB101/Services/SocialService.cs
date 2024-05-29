using Fiorello_PB101.Data;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class SocialService : ISocialService
    {

        private readonly AppDbContext _context;
        public SocialService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Dictionary<string, string>> GetAllAsync()
        {
            return await _context.SocialMedias.ToDictionaryAsync(m => m.Name, m => m.Url);
        }

    }
}
