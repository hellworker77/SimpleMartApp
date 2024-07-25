namespace Domain.Entities;

public class Order : BaseEntity
{
    public virtual User User { get; set; }
    
    public Guid UserId { get; set; }
    
    public virtual OrderProduct OrderProduct { get; set; }
    
    public Guid OrderProductId { get; set; }
}