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
