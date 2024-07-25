namespace WebAPI_Vize_technical_test.src.Domain
{
    public class Product : IEntity
    {
        public string Name { get; private set; }
        public ProductType Type { get; private set; }
        public UnitPriceVO UnitPrice { get; private set; }

        public Product(string name, ProductType type, UnitPriceVO unitPrice)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name cannot be empty");

            if (unitPrice == null)
                throw new ArgumentNullException(nameof(unitPrice));

            Name = name;
            Type = type;
            UnitPrice = unitPrice;
        }

        public Product(
            Guid id,
            string name,
            ProductType type,
            UnitPriceVO unitPrice,
            DateTime createdAt,
            DateTime updatedAt
            ) : this(name, type, unitPrice)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}