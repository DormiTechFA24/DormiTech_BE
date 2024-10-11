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
