using CQRSExample.Application.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CQRSExample.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // [HttpGet("/products")]
        // public async Task<IActionResult> GetProducts()
        // {
        //     var products = await _productRepository.GetAllAsync();


        // }
    }
}