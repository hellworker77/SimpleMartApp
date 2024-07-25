namespace Domain.Entities;

public class OrderProduct : BaseEntity
{
    public virtual IList<Order> Orders { get; set; }
    
    public virtual IList<Product> Products { get; set; }
}