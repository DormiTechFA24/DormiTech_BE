using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IHisItemMaintenanceRepository
{
    Task<IEnumerable<HisItemMaintenance>> GetAll();
    Task<IEnumerable<HisItemMaintenance>> GetByDate(DateTime date);
    Task<IEnumerable<HisItemMaintenance>> GetByDateRange(DateTime startDate, DateTime endDate);
}