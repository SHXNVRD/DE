using System.Drawing;
using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class Report : Identity
{
    public Guid RequestId { get; set; }
    public Request? Request { get; set; }
    public decimal RepairCost { get; set; }
    public required string Message { get; set; }
    public TimeSpan RepairTime { get; set; }
    public virtual ICollection<ReportRepairPart> ReportRepairParts { get; set; } = [];

    private Report()
    { }
    
    public static Report Create(Guid requestId, string message, TimeSpan repairTime)
    {
        return new Report
        {
            RequestId = requestId,
            Message = message,
            RepairTime = repairTime
        };
    }

    public void AddRepairPart(RepairPart repairPart)
    {
        ReportRepairParts.Add(ReportRepairPart.Create(Id, repairPart));
        RepairCost += repairPart.Cost;
    }
}