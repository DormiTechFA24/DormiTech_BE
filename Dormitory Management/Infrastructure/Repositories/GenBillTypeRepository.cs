using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenBillTypeRepository(DormiTechContext context) : IGenBillTypeRepository
{
    private readonly DbSet<GenBillType> _context = context.Set<GenBillType>();

    public async Task<IEnumerable<GenBillType>> GetAll()
    {
        return await _context.ToListAsync();
    }

    public async Task<GenBillType?> GetById(int id)
    {
        return await _context.FindAsync(id);
    }
}