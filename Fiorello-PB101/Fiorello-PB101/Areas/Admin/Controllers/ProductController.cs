using Fiorello_PB101.Data;
using Fiorello_PB101.Helpers;
using Fiorello_PB101.Helpers.Extensions;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Blog;
using Fiorello_PB101.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public ProductController(IProductService productService,
                                 ICategoryService categoryService,
                                 IWebHostEnvironment env,
                                 AppDbContext context)
        {
            _productService = productService;
            _categoryService = categoryService;
            _env = env;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            var produtcs = await _productService.GetAllPaginateAsync(page, take);

            var mappedDatas = _productService.GetMappedDatas(produtcs);

            int totalPage = await GetPageCountAsync(3);

            Paginate<ProductVM> paginateDatas = new(mappedDatas, totalPage, page);


            return View(paginateDatas);
        }

        private async Task<int> GetPageCountAsync(int take)
        {
            int productCount = await _productService.GetCountAsync();

            return (int)Math.Ceiling((decimal)productCount / take);

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var existProduct = await _productService.GetByWithAllDatasAsync((int)id);

            if (existProduct is null) return NotFound();

            List<ProductImageVM> images = new();

            foreach (var item in existProduct.ProductImages)
            {
                images.Add(new ProductImageVM
                {
                    Image = item.Name,
                    IsMain = item.IsMain

                });
            }
            ProductDetailVM response = new()
            {
                Name = existProduct.Name,
                Description = existProduct.Description,
                Category = existProduct.Category.Name,
                Price = existProduct.Price,
                Images = images
            };

            return View(response);

        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.categories = await _categoryService.GetAllSelectedAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateVM request)
        {
            ViewBag.categories = await _categoryService.GetAllSelectedAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            foreach (var item in request.Images)
            {
                if (!item.CheckFileSize(800))
                {
                    ModelState.AddModelError("Images","Image size must be max 800 KB");
                    return View();
                }
                if (!item.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Images","File type must be only image");
                    return View();
                }
            }

           
            List<ProductImage> images = new();

            foreach (var item in request.Images)
            {
                string fileName = $"{Guid.NewGuid()}-{item.FileName}";
                string path = _env.GenerateFilePath("img", fileName);
                await item.SaveFileToLocalAsync(path);
                images.Add(new ProductImage { Name = fileName });
            }

            images.FirstOrDefault().IsMain = true;

            Product product = new()
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Price = decimal.Parse(request.Price.Replace(".", ",")),
                ProductImages = images
            };
           

            await _productService.CreateAsync(product);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete (int? id)
        {
            if (id is null) return BadRequest();

            var existProduct = await _productService.GetByWithAllDatasAsync((int)id);

            if (existProduct is null) return NotFound();

            foreach (var item in existProduct.ProductImages)
            {
                string path = _env.GenerateFilePath("img", item.Name);
                path.DeleteFileFromLocal();
            }

            await _productService.DeleteAsync(existProduct);

            return RedirectToAction(nameof(Index));
           
        }

     
    }
}
