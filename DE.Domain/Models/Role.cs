using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class Role : Identity
{
    public required string Name { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; } = [];
}