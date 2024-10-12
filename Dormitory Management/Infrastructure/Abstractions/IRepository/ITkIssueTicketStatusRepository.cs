using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface ITkIssueTicketStatusRepository
{
    Task<IEnumerable<TkIssueTicketStatus>> GetAll();
    Task<TkIssueTicketStatus> GetById(Guid id);
}