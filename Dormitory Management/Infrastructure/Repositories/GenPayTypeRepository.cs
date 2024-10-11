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
    internal sealed class GenPayTypeRepository : IGenPayTypeRepository
    {
        private readonly DbSet<GenPayType> context;

        public GenPayTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<GenPayType>();
        }

        public async Task<IEnumerable<GenPayType>> GetAll()
        {
            IQueryable<GenPayType> query = context;

            return query;
        }

        public async Task<GenPayType> GetById(Guid id)
        {
            IQueryable<GenPayType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
