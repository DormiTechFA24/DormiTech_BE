using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;
namespace Infrastructure.Repositories
{
    internal sealed class GenEthnicityRepository : IGenEthnicityRepository
    {
        private readonly DbSet<GenEthnicity> context;

        public GenEthnicityRepository(DormiTechContext context)
        {
            this.context = context.Set<GenEthnicity>();
        }

        public async Task<IEnumerable<GenEthnicity>> GetAll()
        {
            IQueryable<GenEthnicity> query = context;

            return query;
        }

        public async Task<GenEthnicity> GetById(Guid id)
        {
            IQueryable<GenEthnicity> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}