using Domain.Model;
using Application.Abstractions.IRepository;

namespace Application.Abstractions.IRepository
{
    public interface IAccRoomRequestRepository : IGenericRepository<AccRoomRequest>
    {
        Task<List<AccRoomRequest>> GetByStudentId(Guid id);
        Task<List<AccRoomRequest>> GetFromDateToDate(DateTime from, DateTime to);
    }
}
