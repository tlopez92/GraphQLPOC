namespace eShop.Catalog.Types;

[ObjectType<Product>]
public static partial class ProductNode
{
    static partial void Configure(IObjectTypeDescriptor<Product> descriptor)
    {
        descriptor
            .Ignore(t => t.BrandId)
            .Ignore(t => t.TypeId)
            .Ignore(t => t.AddStock(default))
            .Ignore(t => t.RemoveStock(default));
    }

    public static async Task<Brand?> GetBrandAsync(
        [Parent] Product product, 
        BrandService brandService, 
        CancellationToken cancellationToken)
        => await brandService.GetBrandByIdAsync(product.BrandId, cancellationToken);
    
    public static async Task<Models.ProductType?> GetProductTypeAsync(
        [Parent] Product product, 
        ProductTypeService productTypeService,
        CancellationToken cancellationToken)
        => await productTypeService.GetProductTypeByIdAsync(product.BrandId, cancellationToken);
}