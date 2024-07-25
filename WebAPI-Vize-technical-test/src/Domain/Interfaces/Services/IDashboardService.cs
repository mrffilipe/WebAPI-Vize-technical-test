namespace WebAPI_Vize_technical_test.src.Domain
{
    public interface IDashboardService
    {
        Task<DashboardVO> GetDashboardAsync();
    }
}