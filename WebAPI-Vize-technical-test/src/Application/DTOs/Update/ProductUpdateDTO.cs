using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductUpdateDTO : IEntityDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public ProductType Type { get; init; }
        public UnitPriceVO UnitPrice { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }

        public ProductUpdateDTO(
            Guid id,
            string name,
            ProductType type,
            UnitPriceVO unitPrice,
            DateTime createdAt,
            DateTime updatedAt
            )
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id cannot be empty", nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or whitespace", nameof(name));

            if (unitPrice == null || unitPrice.Value <= 0)
                throw new ArgumentException("Unit price must be greater than zero and not null", nameof(unitPrice));

            Id = id;
            Name = name;
            Type = type;
            UnitPrice = unitPrice;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}