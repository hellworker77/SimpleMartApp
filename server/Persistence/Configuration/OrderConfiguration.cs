using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasOne<User>(x => x.User)
            .WithOne(x => x.Order)
            .HasForeignKey<Order>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.OrderProduct)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.OrderProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}