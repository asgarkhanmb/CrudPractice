using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Baskets;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Configuration;

namespace Fiorello_PB101.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ISettingService _settingsService;
        private readonly IHttpContextAccessor _accessor;

        public HeaderViewComponent(ISettingService settingService, 
                                   IHttpContextAccessor accessor)
        {
            _settingsService = settingService;
            _accessor = accessor;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<BasketVM> basketDatas = new();
            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }
          

            Dictionary<string,string> settings = await _settingsService.GetAllAsync();

            HeaderVM response = new()
            {
                Settings = settings,
                BasketCount = basketDatas.Sum(m => m.Count),
                BasketTotalPrice = basketDatas.Sum(m=>m.Count*m.Price),
            };

            return await Task.FromResult(View(response));
        }
    }

    public class HeaderVM
    {
        public int BasketCount { get; set; }
        public decimal BasketTotalPrice { get; set; }
        public Dictionary<string,string>Settings { get; set; }
    }

}
