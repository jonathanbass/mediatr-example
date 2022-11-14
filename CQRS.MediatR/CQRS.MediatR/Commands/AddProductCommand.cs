using CQRS.MediatR.Models;
using MediatR;

namespace CQRS.MediatR.Commands
{
    public record AddProductCommand(Product Product) : IRequest;
}
