namespace Application.DTOs.Product;

public sealed class CreateProductDto
{
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public uint Count { get; set; }
    
    public Guid CategoryId { get; }
}