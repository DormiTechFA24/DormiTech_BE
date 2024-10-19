using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    public sealed class AccRoomRequestRepository : GenericRepository<AccRoomRequest>, IAccRoomRequestRepository
    {
        private readonly DbSet<AccRoomRequest> context;

        public AccRoomRequestRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
            this.context = context.Set<AccRoomRequest>();
        }

        public async Task<List<AccRoomRequest>> GetByStudentId(Guid id)
        {
            var query = await context.Where(s => s.AppliedByNavigation!.AccountId.Equals(id)).ToListAsync();

            return query;
        }

        public async Task<List<AccRoomRequest>> GetFromDateToDate(DateTime from, DateTime to)
        {
            var query = await context
                .Where(s => s.AppliedOn > from &&
                s.AppliedOn < to).ToListAsync();

            return query;
        }
    }
}
