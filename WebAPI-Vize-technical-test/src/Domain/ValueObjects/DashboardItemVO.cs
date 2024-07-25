namespace WebAPI_Vize_technical_test.src.Domain
{
    public record DashboardItemVO
    {
        public int Quantity { get; }
        public decimal AverageUnitPrice { get; }

        public DashboardItemVO()
        {
        }

        public DashboardItemVO(int quantity, decimal averageUnitPrice)
        {
            Quantity = quantity;
            AverageUnitPrice = averageUnitPrice;
        }
    }
}