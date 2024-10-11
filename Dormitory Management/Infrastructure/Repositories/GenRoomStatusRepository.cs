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
    internal sealed class GenRoomStatusRepository : IGenRoomStatusRepository
    {
        private readonly DbSet<GenRoomStatus> context;

        public GenRoomStatusRepository(DormiTechContext context)
        {
            this.context = context.Set<GenRoomStatus>();
        }

        public async Task<IEnumerable<GenRoomStatus>> GetAll()
        {
            IQueryable<GenRoomStatus> query = context;

            return query;
        }

        public async Task<GenRoomStatus> GetById(Guid id)
        {
            IQueryable<GenRoomStatus> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
