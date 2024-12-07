using System.Security.AccessControl;
using DE.Domain.Models.Base;

namespace DE.Domain.Models;

public class User : Identity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Patronymic { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; } = [];
    public virtual ICollection<Request> Requests { get; set; } = [];

    private User()
    { }
    
    public static User Create(string firstName, string lastName, string phoneNumber, string login, string passwordHash, string? patronymic = null)
    {
        return new User
        {
            FirstName = firstName,
            LastName = lastName,
            PhoneNumber = phoneNumber,
            Login = login,
            PasswordHash = passwordHash,
            Patronymic = patronymic
        };
    }
}