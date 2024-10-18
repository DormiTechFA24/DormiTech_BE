using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IAccRoomApplicationDocumentRepository
{
    Task<IEnumerable<AccRoomApplicationDocument>> GetAllAsync();
    Task<AccRoomApplicationDocument?> GetByIdAsync(Guid id);
    Task AddAsync(AccRoomApplicationDocument document);
    Task UpdateAsync(AccRoomApplicationDocument document);
    Task DeleteAsync(Guid id);
}