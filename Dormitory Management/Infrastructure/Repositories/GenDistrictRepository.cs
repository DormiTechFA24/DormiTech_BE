using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenDistrictRepository(DormiTechContext context) : IGenDistrictRepository
{
    private readonly DbSet<GenDistrict> _context = context.Set<GenDistrict>();

    public async Task<IEnumerable<GenDistrict>> GetAll()
    {
        return await _context.ToListAsync();
    }

    public async Task<GenDistrict?> GetById(int id)
    {
        return await _context.FindAsync(id);
    }
}