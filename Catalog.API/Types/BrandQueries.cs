using eShop.Catalog.Services;
using HotChocolate.Pagination;
using HotChocolate.Types.Pagination;

namespace eShop.Catalog.Types;

[QueryType]
public static class BrandQueries
{
    [UsePaging]
    public static async Task<Connection<Brand>> GetBrandsAsync(
        PagingArguments pagingArguments,
        BrandService brandService,
        CancellationToken cancellationToken)
    {
        return await brandService
            .GetBrandsAsync(pagingArguments, cancellationToken)
            .ToConnectionAsync();
    }

    public static async Task<Brand?> GetBrandById(
        int id,
        BrandService brandService,
        CancellationToken cancellationToken)
        => await brandService.GetBrandByIdAsync(id, cancellationToken);
}