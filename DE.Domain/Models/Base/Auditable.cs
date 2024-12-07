namespace DE.Domain.Models.Base;

public abstract class Auditable : Identity, IAuditable
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}