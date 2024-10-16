using Application.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal sealed class AccRoomMonthlyRepository : GenericRepository<AccRoomMonthly>, IAccRoomMonthlyRepository
    {
        private readonly DbSet<AccRoomMonthly> context;

        public AccRoomMonthlyRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
            this.context = context.Set<AccRoomMonthly>();
        }

        public async Task<List<AccRoomMonthly>> GetByRoomId(Guid id)
        {
            var query = await context.Where(s => s.RoomId.Equals(id)).ToListAsync();

            return query;
        }

        public async Task<List<AccRoomMonthly>> GetFromDateToDate(DateTime from, DateTime to)
        {
            var query = await context
                .Where(s => s.CreatedOn > from &&
                s.CreatedOn < to).ToListAsync();

            return query;
        }
    }
}
