using HotChocolate.Pagination;

namespace eShop.Catalog.Services;

public sealed class BrandService(CatalogContext context)
{
    public async Task<Page<Brand>> GetBrandsAsync(PagingArguments pagingArguments, CancellationToken cancellationToken)
    {
        return await context.Brands
            .OrderBy(b => b.Name)
            .ThenBy(b => b.Id)
            .ToPageAsync(pagingArguments, cancellationToken);
    }

    public async Task<Brand?> GetBrandByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Brands.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
    }
}