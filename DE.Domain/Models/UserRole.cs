using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class UserRole : Identity
{
    public Guid UserId { get; set; }
    public virtual User? User { get; set; }
    public Guid RoleId { get; set; }
    public virtual Role? Role { get; set; }
}
