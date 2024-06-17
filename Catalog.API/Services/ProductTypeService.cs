using HotChocolate.Pagination;

namespace eShop.Catalog.Services;

public sealed class ProductTypeService(CatalogContext context)
{
    public async Task<Page<ProductType>> GetProductTypesAsync(PagingArguments pagingArguments,
        CancellationToken cancellationToken)
    {
        return await context.ProductTypes
            .OrderBy(p => p.Name)
            .ThenBy(p => p.Id)
            .ToPageAsync(pagingArguments, cancellationToken);
    }

    public async Task<ProductType?> GetProductTypeByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.ProductTypes.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }
}