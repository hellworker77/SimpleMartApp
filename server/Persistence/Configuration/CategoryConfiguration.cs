using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasOne(x => x.CategoryProduct)
            .WithMany(x => x.Categories)
            .HasForeignKey(x => x.CategoryProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}