using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
            return await _context.Sliders.ToListAsync();
        }

        public async Task<SliderInfo> GetSliderInfoAsync()
        {
            return await _context.SlidersInfos.Where(m => !m.SoftDeleted).FirstOrDefaultAsync();
        }
    }
}
