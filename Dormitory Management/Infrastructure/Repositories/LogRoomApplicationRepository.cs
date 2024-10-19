using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public class LogRoomApplicationRepository(DormiTechContext context) : ILogRoomApplicationRepository
{
    private readonly DbSet<LogRoomApplication> _context = context.Set<LogRoomApplication>();

    public async Task<IEnumerable<LogRoomApplication>> GetAll()
    {
        return await _context.ToListAsync();
    }

    public async Task<IEnumerable<LogRoomApplication>> GetByDate(DateTime date)
    {
        return await _context
            .Where(l => l.StatusChangedOn.HasValue && l.StatusChangedOn.Value.Date == date.Date)
            .ToListAsync();
    }

    public async Task<IEnumerable<LogRoomApplication>> GetByDateRange(DateTime startDate, DateTime endDate)
    {
        return await _context
            .Where(l => l.StatusChangedOn.HasValue && l.StatusChangedOn.Value.Date >= startDate.Date &&
                        l.StatusChangedOn.Value.Date <= endDate.Date).ToListAsync();
    }
    
    public async Task<IEnumerable<LogRoomApplication>> GetByStatusChangedBy(Guid accountId)
    {
        return await _context
            .Where(l => l.StatusChangedBy == accountId)
            .ToListAsync();
    }
}