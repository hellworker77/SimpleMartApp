using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser<Guid>
{
    public virtual Order? Order { get; set; }
}