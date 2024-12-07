using DE.Domain.Models;
using DE.Infrastructure.Data.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations;

public class CommentConfiguration : AuditableConfigurationBase<Comment>
{
    protected override void AddCustomConfiguration(EntityTypeBuilder<Comment> builder)
    {
        builder
            .HasOne(c => c.Employee)
            .WithMany(e => e.Comments)
            .HasForeignKey(c => c.EmployeeId);

        builder
            .HasOne(c => c.Request)
            .WithMany(r => r.Comments)
            .HasForeignKey(c => c.RequestId);
    }
}