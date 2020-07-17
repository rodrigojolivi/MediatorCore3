using MediatorCore3.Domain.Commands.Requests;
using MediatorCore3.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatorCore3.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<CreateProductReponse> Create(CreateProductRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
