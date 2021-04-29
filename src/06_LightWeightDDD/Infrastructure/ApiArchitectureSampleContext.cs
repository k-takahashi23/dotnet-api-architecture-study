using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;
using ApiArchitectureSample.Core.Domain.SeedWork;
using ApiArchitectureSample.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ApiArchitectureSample.Infrastructure
{
    public class ApiArchitectureSampleContext : DbContext, IUnitOfWork
    {
        public ApiArchitectureSampleContext(DbContextOptions<ApiArchitectureSampleContext> option) : base(option) { }

        public const string DEFAULT_SCHEMA = "sample";
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        }
    }
}