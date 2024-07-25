namespace Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    
    public virtual CategoryProduct? CategoryProduct { get; set; }
    
    public Guid? CategoryProductId { get; set; }
}