using eShop.Catalog.Services;
using HotChocolate.Pagination;
using HotChocolate.Types.Pagination;

namespace eShop.Catalog.Types;

[QueryType]
public static class ProductTypeQueries
{
    [UsePaging]
    public static async Task<Connection<ProductType>> GetProductTypesAsync(
        PagingArguments pagingArguments,
        ProductTypeService productTypeService,
        CancellationToken cancellationToken)
    {
        return await productTypeService.GetProductTypesAsync(pagingArguments, cancellationToken).ToConnectionAsync();
    }

    public static async Task<ProductType?> GetProductById(
        int id,
        ProductTypeService productTypeService,
        CancellationToken cancellationToken)
        => await productTypeService.GetProductTypeByIdAsync(id, cancellationToken);
}