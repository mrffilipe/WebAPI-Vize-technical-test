namespace WebAPI_Vize_technical_test.src.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public ProductType Type { get; private set; }
        public UnitPriceVO UnitPrice { get; private set; }

        protected Product()
        {
            Name = string.Empty;
            Type = ProductType.Service;
            UnitPrice = new(0);
        }

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
            SetCreatedAt(createdAt);
            SetUpdatedAt(updatedAt);
        }

        public void UpdateUnitPrice(UnitPriceVO newUnitPrice)
        {
            if (newUnitPrice == null)
                throw new ArgumentNullException(nameof(newUnitPrice));

            UnitPrice = newUnitPrice;
        }

        public void Rename(string newName)
        {
            if (string.IsNullOrEmpty(newName))
                throw new ArgumentNullException("Name cannot be empty");

            Name = newName;
        }

        public void ChangeType(ProductType newType)
        {
            Type = newType;
        }
    }
}