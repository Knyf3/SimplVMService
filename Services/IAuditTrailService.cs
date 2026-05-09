using SimplVMService.Models;

namespace SimplVMService.Services
{
    public interface IAuditTrailService
    {
        Task RecordAsync(AuditTrailModel audit);
    }
}