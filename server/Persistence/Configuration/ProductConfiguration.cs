using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasOne(x => x.CategoryProduct)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.OrderProduct)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.OrderProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}