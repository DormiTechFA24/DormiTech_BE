using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenSocialStatusTypeRepository : IGenSocialStatusTypeRepository
    {
        private readonly DbSet<GenSocialStatusType> context;

        public GenSocialStatusTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<GenSocialStatusType>();
        }

        public async Task<IEnumerable<GenSocialStatusType>> GetAll()
        {
            IQueryable<GenSocialStatusType> query = context;

            return query;
        }

        public async Task<GenSocialStatusType> GetById(Guid id)
        {
            IQueryable<GenSocialStatusType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}