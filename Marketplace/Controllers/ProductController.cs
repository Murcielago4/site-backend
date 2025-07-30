using Marketplace.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
       private readonly IProductService _productService;
        public ProductController(IProductService productService) {_productService = productService; }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() { 
         var cards = await _productService.GetAllCardsAsync();
            return Ok(cards);
        
        }
    }
}
