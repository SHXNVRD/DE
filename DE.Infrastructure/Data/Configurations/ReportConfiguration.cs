using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class ReportConfiguration : IdentityConfigurationBase<Report>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<Report> builder)
    {
        builder
            .Property(r => r.Message)
            .IsRequired();

        builder
            .Property(r => r.RepairCost)
            .HasColumnType("numeric(18, 2)")
            .IsRequired();
    }
}