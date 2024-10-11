using Domain.Model;
using Infractstructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Repositories
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
