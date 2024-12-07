using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class ReportRepairPartConfiguration : IdentityConfigurationBase<ReportRepairPart>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<ReportRepairPart> builder)
    {
        builder
            .HasOne(rrp => rrp.Report)
            .WithMany(r => r.ReportRepairParts)
            .HasForeignKey(rrp => rrp.ReportId);

        builder
            .HasOne(rrp => rrp.RepairPart)
            .WithMany(rp => rp.ReportRepairParts)
            .HasForeignKey(rrp => rrp.RepairPartId);
    }
}