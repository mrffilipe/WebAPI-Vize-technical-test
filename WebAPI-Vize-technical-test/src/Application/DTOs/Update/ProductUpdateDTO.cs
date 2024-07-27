using System.ComponentModel.DataAnnotations;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record ProductUpdateDTO : IEntityDTO
    {
        [Required]
        public Guid Id { get; init; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Type is required")]
        public ProductType Type { get; init; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; init; }

        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }

        public ProductUpdateDTO(
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