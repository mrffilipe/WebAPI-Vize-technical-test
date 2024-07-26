using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductCreateDTO
    {
        public string Name { get; init; }
        public ProductType Type { get; init; }
        public decimal Price { get; init; }

        public ProductCreateDTO(string name, ProductType type, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or whitespace", nameof(name));

            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero and not null", nameof(price));

            Name = name;
            Type = type;
            Price = price;
        }
    }
}