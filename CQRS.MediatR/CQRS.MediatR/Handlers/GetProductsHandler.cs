using CQRS.MediatR.Models;
using CQRS.MediatR.Queries;
using MediatR;

namespace CQRS.MediatR.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetProducts();
        }
    }
}
