
using Infrastructure.Abstractions.IRepository;

namespace Application.Abstractions;

public interface IUnitOfWork
{
    public IFacRoomRepository roomRepository { get; }
    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    void Dispose();
}