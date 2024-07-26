using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductCreateDTO
    {
        public string Name { get; init; }
        public ProductType Type { get; init; }
        public UnitPriceVO UnitPrice { get; init; }

        public ProductCreateDTO(string name, ProductType type, UnitPriceVO unitPrice)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or whitespace", nameof(name));

            if (unitPrice == null || unitPrice.Value <= 0)
                throw new ArgumentException("Unit price must be greater than zero and not null", nameof(unitPrice));

            Name = name;
            Type = type;
            UnitPrice = unitPrice;
        }
    }
}