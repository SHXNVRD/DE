using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class RoleConfiguration : IdentityConfigurationBase<Role>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<Role> builder)
    { }
}