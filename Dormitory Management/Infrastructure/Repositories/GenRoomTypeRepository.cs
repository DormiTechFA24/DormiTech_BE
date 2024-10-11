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
    internal sealed class GenRoomTypeRepository : IGenRoomTypeRepository
    {
        private readonly DbSet<GenRoomType> context;

        public GenRoomTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<GenRoomType>();
        }

        public async Task<IEnumerable<GenRoomType>> GetAll()
        {
            IQueryable<GenRoomType> query = context;

            return query;
        }

        public async Task<GenRoomType> GetById(Guid id)
        {
            IQueryable<GenRoomType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
