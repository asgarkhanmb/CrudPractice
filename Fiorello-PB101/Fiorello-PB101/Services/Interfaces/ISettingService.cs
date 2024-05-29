namespace Fiorello_PB101.Services.Interfaces
{
    public interface ISettingService
    {
        Task<Dictionary<string, string>> GetAllAsync();
    }
}
