using Application.Abstractions;
using Domain.Model;
using Application.Abstractions.IRepository;
namespace Infrastructure;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DormiTechContext _context;
    //public UnitOfWork(DormiTechContext context) => _context = context;

    private bool disposed = false;

    #region demo
    private readonly IFacRoomRepository _roomRepository;

    public UnitOfWork(DormiTechContext context, IFacRoomRepository roomRepository)
    {
        _context = context;
        _roomRepository = roomRepository;
    }

    public IFacRoomRepository roomRepository => _roomRepository;
    #endregion
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }



    public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync();
    }
}