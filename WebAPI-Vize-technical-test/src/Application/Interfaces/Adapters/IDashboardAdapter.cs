namespace WebAPI_Vize_technical_test.src.Application
{
    public interface IDashboardAdapter
    {
        Task<DashboardResponseDTO> GetDashboardAsync();
    }
}