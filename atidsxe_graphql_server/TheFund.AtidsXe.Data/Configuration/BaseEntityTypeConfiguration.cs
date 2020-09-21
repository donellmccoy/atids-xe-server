using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TheFund.AtidsXe.Data.Configuration
{
    public abstract class BaseEntityTypeConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : class
    {
        public void Configure(EntityTypeBuilder<TBase> entityTypeBuilder)
        {
        }

        public abstract void ConfigureOtherProperties<TEntity>(EntityTypeBuilder<TEntity> builder) where TEntity : class;
    }
}
