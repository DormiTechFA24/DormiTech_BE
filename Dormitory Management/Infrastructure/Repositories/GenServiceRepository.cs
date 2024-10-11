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
    internal sealed class GenServiceRepository : IGenServiceRepository
    {
        private readonly DbSet<GenService> context;

        public GenServiceRepository(DormiTechContext context)
        {
            this.context = context.Set<GenService>();
        }

        public async Task<IEnumerable<GenService>> GetAll()
        {
            IQueryable<GenService> query = context;

            return query;
        }

        public async Task<GenService> GetById(Guid id)
        {
            IQueryable<GenService> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
