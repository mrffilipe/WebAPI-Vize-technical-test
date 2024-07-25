namespace WebAPI_Vize_technical_test.src.Domain
{
    public record UnitPriceVO
    {
        public decimal Value { get; }

        public UnitPriceVO()
        {
        }

        public UnitPriceVO(decimal value)
        {
            Value = value;
        }
    }
}