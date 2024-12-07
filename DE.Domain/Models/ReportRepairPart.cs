using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class ReportRepairPart : Identity
{
    public Guid ReportId { get; set; }
    public Report? Report { get; set; }
    public Guid RepairPartId { get; set; }
    public RepairPart? RepairPart { get; set; }

    private ReportRepairPart()
    { }

    public static ReportRepairPart Create(Guid reportId, RepairPart repairPart)
    {
        return new ReportRepairPart
        {
            ReportId = reportId,
            RepairPart = repairPart
        };
    }
}