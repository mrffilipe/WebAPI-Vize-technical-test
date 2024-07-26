using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductResponseDTO : IEntityDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public ProductType Type { get; init; }
        public decimal Price { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }

        public ProductResponseDTO(
            Guid id,
            string name,
            ProductType type,
            decimal price,
            DateTime createdAt,
            DateTime updatedAt
            )
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id cannot be empty", nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or whitespace", nameof(name));

            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero and not null", nameof(price));

            Id = id;
            Name = name;
            Type = type;
            Price = price;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}