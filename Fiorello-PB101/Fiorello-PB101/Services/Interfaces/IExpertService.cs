using Fiorello_PB101.Models;
using Fiorello_PB101.ViewModels.Expert;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface IExpertService
    {
        Task<IEnumerable<ExpertVM>> GetAllAsync();
    }
}
