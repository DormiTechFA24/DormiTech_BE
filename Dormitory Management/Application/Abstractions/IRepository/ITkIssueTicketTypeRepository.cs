using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface ITkIssueTicketTypeRepository
{
    Task<IEnumerable<TkIssueTicketType>> GetAll();
    Task<TkIssueTicketType> GetById(Guid id);
}