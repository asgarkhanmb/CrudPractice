using Fiorello_PB101.Models;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync();
        Task<SliderInfo> GetSliderInfoAsync();
    }
}
