using System.Linq.Expressions;
using DE.Domain.Models.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations.Base;

public abstract class AuditableConfigurationBase<T> : IdentityConfigurationBase<T> where T : Auditable
{
    protected override void AddBaseConfiguration(EntityTypeBuilder<T> builder)
    {
        builder
            .Property(a => a.CreatedAt)
            .HasConversion(dateTime => dateTime.Kind == DateTimeKind.Utc ? dateTime : DateTime.SpecifyKind(dateTime, DateTimeKind.Utc),
                dateTime => dateTime.Kind == DateTimeKind.Utc ? dateTime : DateTime.SpecifyKind(dateTime, DateTimeKind.Utc))
            .IsRequired();
        
        builder
            .Property(a => a.UpdatedAt)
            .HasConversion(dateTime => dateTime!.Value.Kind == DateTimeKind.Utc ? dateTime : DateTime.SpecifyKind(dateTime.Value, DateTimeKind.Utc),
                dateTime => dateTime!.Value.Kind == DateTimeKind.Utc ? dateTime : DateTime.SpecifyKind(dateTime.Value, DateTimeKind.Utc));
        
        AddCustomConfiguration(builder);
    }

    protected abstract override void AddCustomConfiguration(EntityTypeBuilder<T> builder);
}