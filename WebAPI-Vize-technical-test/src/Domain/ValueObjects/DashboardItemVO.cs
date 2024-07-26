namespace WebAPI_Vize_technical_test.src.Domain
{
    public record DashboardItemVO
    {
        public int Quantity { get; }
        public decimal AverageUnitPrice { get; }

        public DashboardItemVO(int quantity, decimal averageUnitPrice)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be negative");

            if (averageUnitPrice < 0)
                throw new ArgumentOutOfRangeException(nameof(averageUnitPrice), "Average unit price cannot be negative");

            Quantity = quantity;
            AverageUnitPrice = averageUnitPrice;
        }

        public override string ToString() => $"Quantity: {Quantity}, Average Unit Price: ${AverageUnitPrice:F2}";
    }
}