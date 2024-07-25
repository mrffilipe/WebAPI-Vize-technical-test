using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductResponseDTO : IEntityDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public ProductType Type { get; init; } = ProductType.Service;
        public UnitPriceVO UnitPrice { get; init; } = new(0);
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}