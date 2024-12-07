using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class RepairPartConfiguration : IdentityConfigurationBase<RepairPart>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<RepairPart> builder)
    { }
}