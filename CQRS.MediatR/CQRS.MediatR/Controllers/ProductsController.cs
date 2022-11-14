using CQRS.MediatR.Commands;
using CQRS.MediatR.Models;
using CQRS.MediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CQRS.MediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _sender.Send(new GetProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id:int}", Name = "GetProductById")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _sender.Send(new GetProductByIdQuery(id));
            return Ok(product);
        }
        
        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody]Product product)
        {
            await _sender.Send(new AddProductCommand(product));
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
