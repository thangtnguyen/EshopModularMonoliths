

namespace Catalog.Products.Features.GetProducts
{
    public record GetProductQuery()
        : IQuery<GetProductResult>;

    public record GetProductResult(IEnumerable<ProductDto> Products);

    internal class GetProductsHandler(CatalogDbContext dbContext)
        : IQueryHandler<GetProductQuery, GetProductResult>
    {
        public async Task<GetProductResult> Handle(GetProductQuery query, CancellationToken cancellationToken)
        {
            // get products using dbContext
            // return result

            var products = await dbContext.Products
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            //mapping product entity to productdto using Mapster
            var productDtos = products.Adapt<List<ProductDto>>();

            return new GetProductResult(productDtos);
        }
    }
}
