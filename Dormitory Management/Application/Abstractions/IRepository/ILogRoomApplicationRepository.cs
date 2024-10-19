using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface ILogRoomApplicationRepository
{
    Task<IEnumerable<LogRoomApplication>> GetAll();
    Task<IEnumerable<LogRoomApplication>> GetByDate(DateTime date);
    Task<IEnumerable<LogRoomApplication>> GetByDateRange(DateTime startDate, DateTime endDate);
}