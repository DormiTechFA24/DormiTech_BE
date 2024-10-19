using Domain.Model;
using Application.Abstractions.IRepository;

namespace Application.Abstractions.IRepository
{
    public interface ITkIssueTicketPhotoRepository : IGenericRepository<TkIssueTicketPhoto>
    {
        Task<List<TkIssueTicketPhoto>> GetByTicketId(Guid id);
    }
}
