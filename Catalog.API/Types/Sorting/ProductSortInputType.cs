using HotChocolate.Data.Sorting;

namespace eShop.Catalog.Types.Sorting;

public sealed class ProductSortInputType : SortInputType<Product>
{
    protected override void Configure(ISortInputTypeDescriptor<Product> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(t => t.Brand).Type<BrandSortInputType>();
        descriptor.Field(t => t.Name);
        descriptor.Field(t => t.Price);
        descriptor.Field(t => t.Type).Type<ProductSortInputType>();
    }
}

public sealed class BrandSortInputType : SortInputType<Brand>
{
    protected override void Configure(ISortInputTypeDescriptor<Brand> descriptor)
    {
        descriptor.BindFieldsExplicitly();
        descriptor.Field(t => t.Name);
    }
}