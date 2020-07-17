using MediatorCore3.Domain.Commands.Requests;
using MediatorCore3.Domain.Commands.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorCore3.Domain.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductReponse>
    {
        public Task<CreateProductReponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateProductReponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price,
                Active = request.Active,
                DateCreated = DateTime.Now,
            };

            return Task.FromResult(result);
        }
    }
}
