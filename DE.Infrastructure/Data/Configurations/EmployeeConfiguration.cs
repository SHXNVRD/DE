using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class EmployeeConfiguration : IdentityConfigurationBase<Employee>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<Employee> builder)
    {
        builder
            .Property(u => u.FirstName)
            .IsRequired();
        
        builder
            .Property(u => u.LastName)
            .IsRequired();
        
        builder
            .Property(u => u.PhoneNumber)
            .IsRequired();
        
        builder
            .Property(u => u.Login)
            .IsRequired();
        
        builder
            .Property(u => u.PasswordHash)
            .IsRequired();
    }
}