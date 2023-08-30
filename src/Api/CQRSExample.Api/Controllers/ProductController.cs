using CQRSExample.Application.Features.Commands.Product;
using CQRSExample.Application.Features.Queries.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSExample.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ISender _mediator;

        public ProductController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var query = new GetAllProductsQuery();

            return Ok(await _mediator.Send(query));

        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(AddProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}