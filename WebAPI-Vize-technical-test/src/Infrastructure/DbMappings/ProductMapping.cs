using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public class ProductMapping : IEntityMapping<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.ToTable("products");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.Type)
                .HasColumnName("type")
                .IsRequired();

            builder.ComplexProperty(x => x.UnitPrice)
                .Property(x => x.Value)
                .HasColumnName("price")
                .IsRequired();
        }
    }
}