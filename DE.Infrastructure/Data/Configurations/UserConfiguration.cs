using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class UserConfiguration : IdentityConfigurationBase<User>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<User> builder)
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