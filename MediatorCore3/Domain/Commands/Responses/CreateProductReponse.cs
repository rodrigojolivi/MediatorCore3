using System;

namespace MediatorCore3.Domain.Commands.Responses
{
    public class CreateProductReponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
