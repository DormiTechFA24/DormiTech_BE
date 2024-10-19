using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface ITkIssueTicketStatusRepository
{
    Task<IEnumerable<TkIssueTicketStatus>> GetAll();
    Task<TkIssueTicketStatus> GetById(Guid id);
}