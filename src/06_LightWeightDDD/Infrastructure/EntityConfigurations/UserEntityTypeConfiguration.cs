using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiArchitectureSample.Infrastructure.EntityConfigurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users", ApiArchitectureSampleContext.DEFAULT_SCHEMA);

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(u => u.Name)
                .IsRequired();

            builder.OwnsOne(u => u.Address);
        }
    }
}