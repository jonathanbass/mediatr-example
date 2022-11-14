using MediatR;
using Microsoft.AspNetCore.Mvc;

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


    }
}
