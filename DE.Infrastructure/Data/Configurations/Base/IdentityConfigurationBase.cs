using DE.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Configurations.Base;

public abstract class IdentityConfigurationBase<T> : ConfigurationBase<T> where T : Identity
{
    protected override void AddBaseConfiguration(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(i => i.Id);
        builder
            .Property(i => i.Id)
            .IsRequired();
        
        AddCustomConfiguration(builder);
    }

    protected abstract void AddCustomConfiguration(EntityTypeBuilder<T> builder);
}