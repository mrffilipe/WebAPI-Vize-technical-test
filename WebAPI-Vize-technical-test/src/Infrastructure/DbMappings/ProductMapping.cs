using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public class ProductMapping : EntityMapping<Product>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.Property(p => p.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Type)
                .HasColumnName("type")
                .IsRequired();

            builder.OwnsOne(p => p.UnitPrice, unitPriceBuilder =>
            {
                unitPriceBuilder.Property(up => up.Value)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
            });

            builder.HasIndex(p => p.Name)
                .HasDatabaseName("idx_product_name");
        }
    }
}