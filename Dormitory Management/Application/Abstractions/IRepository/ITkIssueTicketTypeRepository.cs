using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface ITkIssueTicketTypeRepository
{
    Task<IEnumerable<TkIssueTicketType>> GetAll();
    Task<TkIssueTicketType> GetById(Guid id);
}