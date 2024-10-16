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
    internal sealed class AccRoomStudentMonthlyRepository : GenericRepository<AccRoomStudentMonthly>, IAccRoomStudentMonthlyRepository
    {
        private readonly DbSet<AccRoomStudentMonthly> context;

        public AccRoomStudentMonthlyRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
            this.context = context.Set<AccRoomStudentMonthly>();
        }

        public async Task<List<AccRoomStudentMonthly>> GetByStudentId(Guid id)
        {
            var query = await context.Where(s => s.StudentId.Equals(id)).ToListAsync();

            return query;
        }
    }
}
