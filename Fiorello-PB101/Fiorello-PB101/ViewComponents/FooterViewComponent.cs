
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fiorello_PB101.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly ISocialService _socialService;

        public FooterViewComponent(ISocialService socialService)
        {
            _socialService = socialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(await _socialService.GetAllAsync()));
        }
        public class FooterVMVC
        {
            public IEnumerable<SocialMedia> SocialMedias { get; set; }
            public SocialMedia SocialMedia { get; set; }
        }

    }
}
