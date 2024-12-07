using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class Comment : Auditable
{
    public Guid EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public Guid RequestId { get; set; }
    public Request? Request { get; set; }
    public required string Message { get; set; }

    private Comment()
    { }
    
    public static Comment Create(Guid employeeId, Guid requestId, string message)
    {
        return new Comment
        {
            EmployeeId = employeeId,
            RequestId = requestId,
            Message = message
        };
    }

    public void EditMessage(string newMessage)
    {
        Message = newMessage;
        UpdatedAt = DateTime.UtcNow;
    }
}