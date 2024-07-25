using Application.DTOs.Product;

namespace Application.DTOs.Order;

public sealed class OrderDetailDto
{
    public Guid Id { get; set; }
    
    public IList<ProductDetailDto> Products { get; set; }
}