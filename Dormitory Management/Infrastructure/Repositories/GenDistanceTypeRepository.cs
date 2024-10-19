using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public class GenDistanceTypeRepository(DormiTechContext context) : IGenDistanceTypeRepository
{
    private readonly DbSet<GenDistanceType> _context = context.Set<GenDistanceType>();

    public async Task<IEnumerable<GenDistanceType>> GetAll()
    {
        return await _context.ToListAsync();
    }

    public async Task<GenDistanceType?> GetById(int id)
    {
        return await _context.FindAsync(id);
    }
}