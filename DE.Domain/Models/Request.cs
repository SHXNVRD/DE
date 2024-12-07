using System.Security;
using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class Request : Auditable
{
    public Guid ClientId { get; set; }
    public User? Client { get; set; }
    public Guid MasterId { get; set; }
    public Employee? Master { get; set; }
    public Report? Report { get; set; }
    public TechnicType TechnicType { get; set; }
    public required string TechnicModel { get; set; }
    public Status Status { get; set; }
    public required string Description { get; set; }
    public DateTime CompletedAt { get; set; }
    public virtual ICollection<Comment> Comments { get; set; } = [];

    private Request()
    { }
    
    public static Request Create(Guid clientId, Guid masterId, TechnicType technicType, string technicModel, string description, DateTime completedAt)
    {
        return new Request
        {
            ClientId = clientId,
            MasterId = masterId,
            TechnicType = technicType,
            TechnicModel = technicModel,
            Description = description,
            Status = Status.Requested,
            CompletedAt = completedAt
        };
    }

    public void AddReport(Report report)
    {
        Report = Report;
    }
}