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
    internal sealed class GenItemStatusRepository : IGenItemStatusRepository
    {
        private readonly DbSet<GenItemStatus> context;

        public GenItemStatusRepository(DormiTechContext context)
        {
            this.context = context.Set<GenItemStatus>();
        }

        public async Task<IEnumerable<GenItemStatus>> GetAll()
        {
            IQueryable<GenItemStatus> query = context;

            return query;
        }

        public async Task<GenItemStatus> GetById(Guid id)
        {
            IQueryable<GenItemStatus> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
