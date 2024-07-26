using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    /// <summary>
    /// Provides a base class for configuring entity mappings.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity being configured.</typeparam>
    public abstract class EntityMapping<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity"/>.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity.</param>
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .HasColumnName("updated_at")
                .IsRequired();

            // Call the additional configuration method for further customization in derived classes
            ConfigureEntity(builder);
        }

        /// <summary>
        /// Allows derived classes to add additional configuration.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity.</param>
        protected abstract void ConfigureEntity(EntityTypeBuilder<TEntity> builder);
    }
}