
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels;
using Fiorello_PB101.ViewModels.Baskets;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Fiorello_PB101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly IExpertService _expertService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _accessor;

        public HomeController(ISliderService sliderService,
                              IBlogService blogService,
                              IExpertService expertService,
                              ICategoryService categoryService,
                              IProductService productService,
                              IHttpContextAccessor accessor)
                                                              
        {
            _sliderService = sliderService;
            _blogService = blogService;
            _expertService = expertService;
            _categoryService = categoryService;
            _productService = productService;
            _accessor = accessor;
            
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new()
            {

               
                Blogs=await _blogService.GetAllAsync(3),
                Experts=await _expertService.GetAllAsync(),
                Categories=await _categoryService.GetAllAsync(),
                Products=await _productService.GetAllWithImageAsync(),
               
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToBasket(int? id)
        {
            if (id is null) return BadRequest();

            var product = await _productService.GetByIdAsync((int)id);

            if (product == null) return NotFound();

            List<BasketVM> basketDatas;

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basketDatas= new List<BasketVM>();
            }


            var existBasketData = basketDatas.FirstOrDefault(m => m.Id == id);
            
            if (existBasketData is not null)
            {
                existBasketData.Count++;
            }
            else
            {

                basketDatas.Add(new BasketVM
                {
                    Id = (int)id,
                    Price = product.Price,
                    Count = 1

                });
            }

            _accessor.HttpContext.Response.Cookies.Append("basket",JsonConvert.SerializeObject(basketDatas));
 

            int count = basketDatas.Sum(m => m.Count);
            decimal totalPrice = basketDatas.Sum(m=> m.Price);


            return Ok(new {count,totalPrice});
        }
    }
}
