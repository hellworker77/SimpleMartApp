using Application.DTOs.Category;

namespace Application.DTOs.Product;

public sealed class ProductDetailDto
{
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public uint Count { get; set; }
    
    public uint Obtained { get; set; }
    
    public CategoryDto Category { get; set; }
}