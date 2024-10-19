using Domain.Model;
using Application.Abstractions.IRepository;

namespace Application.Abstractions.IRepository;

public interface IAccRoomStudentMonthlyRepository : IGenericRepository<AccRoomStudentMonthly>
{
    Task<List<AccRoomStudentMonthly>> GetByStudentId(Guid id);
}
