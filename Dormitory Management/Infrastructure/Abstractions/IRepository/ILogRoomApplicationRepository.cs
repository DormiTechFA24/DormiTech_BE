using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface ILogRoomApplicationRepository
{
    Task<IEnumerable<LogRoomApplication>> GetAll();
    Task<IEnumerable<LogRoomApplication>> GetByDate(DateTime date);
    Task<IEnumerable<LogRoomApplication>> GetByDateRange(DateTime startDate, DateTime endDate);
    Task<IEnumerable<LogRoomApplication>> GetByStatusChangedBy(Guid accountId);
}