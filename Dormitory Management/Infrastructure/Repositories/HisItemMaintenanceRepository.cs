using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class HisItemMaintenanceRepository(DormiTechContext context) : IHisItemMaintenanceRepository
{
    private readonly DbSet<HisItemMaintenance> _context = context.Set<HisItemMaintenance>();

    public async Task<IEnumerable<HisItemMaintenance>> GetAll()
    {
        return await _context.ToListAsync();
    }

    public async Task<IEnumerable<HisItemMaintenance>> GetByDate(DateTime date)
    {
        return await _context
            .Where(h => h.ReportedAt.HasValue && h.ReportedAt.Value.Date == date.Date)
            .ToListAsync();
    }

    public async Task<IEnumerable<HisItemMaintenance>> GetByDateRange(DateTime startDate, DateTime endDate)
    {
        return await _context
            .Where(h => h.ReportedAt.HasValue && h.ReportedAt.Value.Date >= startDate.Date &&
                        h.ReportedAt.Value.Date <= endDate.Date)
            .ToListAsync();
    }
}