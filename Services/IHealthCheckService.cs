
namespace SimplVMService.Services
{
    public interface IHealthCheckService
    {
        Task<bool> IsServerOK();
    }
}