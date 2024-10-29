using Domain.Model;
using Application.Abstractions.IRepository;

namespace Application.Abstractions.IRepository
{
    public interface IAccRoomMonthlyRepository
    {
        Task<List<AccRoomMonthly>> GetAll();
        Task<List<AccRoomMonthly>> GetByRoomId(Guid id);
        Task<List<AccRoomMonthly>> GetFromDateToDate(DateTime from, DateTime to);
    }
}
