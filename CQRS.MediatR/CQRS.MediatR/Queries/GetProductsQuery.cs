using CQRS.MediatR.Models;
using MediatR;

namespace CQRS.MediatR.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>;
}
