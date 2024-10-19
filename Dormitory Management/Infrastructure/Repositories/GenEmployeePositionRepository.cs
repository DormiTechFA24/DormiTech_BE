using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    public sealed class GenEmployeePositionRepository : IGenEmployeePositionRepository
    {
        private readonly DbSet<GenEmployeePosition> context;

        public GenEmployeePositionRepository(DormiTechContext context)
        {
            this.context = context.Set<GenEmployeePosition>();
        }

        public async Task<IEnumerable<GenEmployeePosition>> GetAll()
        {
            IQueryable<GenEmployeePosition> query = context;

            return query;
        }

        public async Task<GenEmployeePosition> GetById(Guid id)
        {
            IQueryable<GenEmployeePosition> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}