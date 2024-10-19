using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
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