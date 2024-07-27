using System.ComponentModel.DataAnnotations;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductCreateDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Type is required")]
        public ProductType Type { get; init; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
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