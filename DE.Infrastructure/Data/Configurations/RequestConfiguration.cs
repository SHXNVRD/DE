using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class RequestConfiguration : AuditableConfigurationBase<Request>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<Request> builder)
    {
        builder
            .HasOne(r => r.Client)
            .WithMany(c => c.Requests)
            .HasForeignKey(r => r.ClientId);

        builder
            .HasOne(r => r.Master)
            .WithMany(e => e.Requests)
            .HasForeignKey(r => r.MasterId);

        builder
            .HasOne(req => req.Report)
            .WithOne(rep => rep.Request)
            .HasForeignKey<Report>(rep => rep.RequestId);

        builder
            .Property(r => r.TechnicType)
            .HasConversion<int>()
            .IsRequired();

        builder
            .Property(r => r.Status)
            .HasConversion<string>()
            .IsRequired();
    }
}