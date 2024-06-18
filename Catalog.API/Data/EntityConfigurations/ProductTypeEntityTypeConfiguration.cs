using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductType = eShop.Catalog.Models.ProductType;

namespace eShop.Catalog.Data.EntityConfigurations;

internal sealed class ProductTypeEntityTypeConfiguration : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        builder
            .ToTable("ProductTypes");

        builder
            .Property(cb => cb.Name)
            .HasMaxLength(100);
    }
}
