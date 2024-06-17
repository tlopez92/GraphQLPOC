using HotChocolate.Pagination;

namespace eShop.Catalog.Services;

public sealed class ProductService(CatalogContext context)
{
    public async Task<Page<Product>> GetProductsAsync(PagingArguments pagingArguments,
        CancellationToken cancellationToken)
    {
        return await context.Products
            .OrderBy(p => p.Name)
            .ThenBy(p => p.Id)
            .ToPageAsync(pagingArguments, cancellationToken);
    }

    public async Task<Product?> GetProductByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Products.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }
}