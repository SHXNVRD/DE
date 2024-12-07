using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class RepairPart : Identity
{
    public required string Title { get; set; }
    public decimal Cost { get; set; }
    public virtual ICollection<ReportRepairPart> ReportRepairParts { get; set; } = [];

    private RepairPart()
    { }
    
    public static RepairPart Create(string title, decimal cost)
    {
        return new RepairPart
        {
            Title = title,
            Cost = cost
        };
    }
}