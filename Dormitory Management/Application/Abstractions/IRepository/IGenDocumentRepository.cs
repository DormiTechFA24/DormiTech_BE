using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenDocumentRepository
{
    Task<IEnumerable<GenDocument>> GetAll();
    Task<GenDocument> GetById(Guid id);
}