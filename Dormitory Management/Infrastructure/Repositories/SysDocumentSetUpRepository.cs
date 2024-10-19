using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public class SysDocumentSetUpRepository(DormiTechContext context) : ISysDocumentSetUpRepository
{
    private readonly DbSet<SysDocumentSetUp> _context = context.Set<SysDocumentSetUp>();

    public void Create(SysDocumentSetUp sysDocumentSetUp)
    {
        _context.Add(sysDocumentSetUp);
    }

    public async Task Delete(int id)
    {
        await _context
            .AsQueryable()
            .Where(a => a.DocumentTypeId == id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<SysDocumentSetUp>> Get()
    {
        IQueryable<SysDocumentSetUp> query = _context;

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<SysDocumentSetUp>> Search(string email = "")
    {
        IQueryable<SysDocumentSetUp> query = _context;

        return await query.ToListAsync();
    }

    public void Update(SysDocumentSetUp sysDocumentSetUp)
    {
        _context.Update(sysDocumentSetUp);
    }

    public async Task<SysDocumentSetUp?> GetById(int id)
    {
        return await _context
            .AsQueryable()
            .FirstOrDefaultAsync(a => a.DocumentTypeId == id);
    }
}