using MediatorCore3.Domain.Commands.Responses;
using MediatR;

namespace MediatorCore3.Domain.Commands.Requests
{
    public class CreateProductRequest : IRequest<CreateProductReponse>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
    }
}
