using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenPunishmentTypeRepository : IGenPunishmentTypeRepository
    {
        private readonly DbSet<GenPunishmentType> context;

        public GenPunishmentTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<GenPunishmentType>();
        }

        public async Task<IEnumerable<GenPunishmentType>> GetAll()
        {
            IQueryable<GenPunishmentType> query = context;

            return query;
        }

        public async Task<GenPunishmentType> GetById(Guid id)
        {
            IQueryable<GenPunishmentType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}