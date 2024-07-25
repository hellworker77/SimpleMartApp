namespace Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public uint Count { get; set; }
    
    public uint Obtained { get; set; }
    
    public virtual CategoryProduct? CategoryProduct { get; set; }
    
    public Guid? CategoryProductId { get; set; }
    
    public virtual OrderProduct? OrderProduct { get; set; }
    
    public Guid? OrderProductId { get; set; }
}