using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Fiorello_PB101.Controllers
{
    public class ProductController:Controller
    {
     private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            string hashData=Guid.NewGuid().ToString();
            ViewBag.Hash=hashData;
            if (id is null) return BadRequest(ModelState);
            Product product = await _productService.GetByWithAllDatasAsync((int)id);   
            if(product is null) return NotFound();  
            return View(product);
        }
    }
}
