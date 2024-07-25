namespace Domain.Entities;

public class CategoryProduct : BaseEntity
{
    public virtual IList<Category> Categories { get; set; }
    
    public virtual IList<Product> Products { get; set; }
}