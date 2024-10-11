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
    internal sealed class GenWardRepository : IGenWardRepository
    {
        private readonly DbSet<GenWard> context;

        public GenWardRepository(DormiTechContext context)
        {
            this.context = context.Set<GenWard>();
        }

        public async Task<IEnumerable<GenWard>> GetAll()
        {
            IQueryable<GenWard> query = context;

            return query;
        }

        public async Task<GenWard> GetById(Guid id)
        {
            IQueryable<GenWard> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}

