namespace Application.DTOs.Order;

public sealed class OrderProductDto
{
    public uint Count { get; set; }
    
    public Guid ProductId { get; set; }
}