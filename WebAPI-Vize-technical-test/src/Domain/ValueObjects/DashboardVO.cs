namespace WebAPI_Vize_technical_test.src.Domain
{
    public record DashboardVO
    {
        public DashboardItemVO Material { get; }
        public DashboardItemVO Service { get; }

        public DashboardVO(DashboardItemVO material, DashboardItemVO service)
        {
            Material = material ?? throw new ArgumentNullException(nameof(material));
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public override string ToString() => $"Material: {Material}, Service: {Service}";
    }
}