using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenModuleTypeRepository : IGenModuleTypeRepository
    {
        private readonly DbSet<GenModuleType> context;

        public GenModuleTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<GenModuleType>();
        }

        public async Task<IEnumerable<GenModuleType>> GetAll()
        {
            IQueryable<GenModuleType> query = context;

            return query;
        }

        public async Task<GenModuleType> GetById(Guid id)
        {
            IQueryable<GenModuleType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}