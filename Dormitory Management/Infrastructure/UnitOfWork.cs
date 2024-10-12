using Domain.Abstractions;
using Domain.Model;

namespace Infrastructure;

internal class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DormiTechContext _context;
    public UnitOfWork(DormiTechContext context) => _context = context;

    private bool disposed = false;

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