using CQRS.MediatR.Models;
using MediatR;

namespace CQRS.MediatR.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
