using BYSResults;
namespace Day06Demo.Services;

public record DashboardData(int NotificationCount, int ProductCount, string UserName);

public interface IDashboardService
{
    Task<Result<DashboardData>> GetDashboardDataAsync();
}
