using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public sealed class GenRoomStatusRepository : IGenRoomStatusRepository
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