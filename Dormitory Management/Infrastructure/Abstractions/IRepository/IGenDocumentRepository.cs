using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenDocumentRepository
{
    Task<IEnumerable<GenDocument>> GetAll();
    Task<GenDocument> GetById(Guid id);
}