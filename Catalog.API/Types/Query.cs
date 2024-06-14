namespace eShop.Catalog.Types;

public class Query
{
    [UsePaging(DefaultPageSize = 1, MaxPageSize = 10)]
    [UseProjection]
    public IQueryable<Brand> GetBrands(CatalogContext context)
        => context.Brands;
    
    [UseFirstOrDefault]
    [UseProjection]
    public IQueryable<Brand> GetBrandById(int id, CatalogContext context)
        => context.Brands.Where(t => t.Id == id);
    
    [UsePaging(DefaultPageSize = 1, MaxPageSize = 10)]
    [UseProjection]
    public IQueryable<Product> GetProducts(CatalogContext context)
        => context.Products;

    [UseFirstOrDefault]
    [UseProjection]
    public IQueryable<Product> GetProductById(int id, CatalogContext context)
        => context.Products.Where(t => t.Id == id);
    
    [UsePaging]
    [UseProjection]
    public IQueryable<ProductType> GetProductTypes(CatalogContext context)
        => context.ProductTypes;
}