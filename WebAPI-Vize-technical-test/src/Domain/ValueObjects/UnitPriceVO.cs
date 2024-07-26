namespace WebAPI_Vize_technical_test.src.Domain
{
    public record UnitPriceVO
    {
        public decimal Value { get; }

        public UnitPriceVO(decimal value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Unit price cannot be negative");

            Value = value;
        }

        public override string ToString() => $"{Value:F2}";
    }
}