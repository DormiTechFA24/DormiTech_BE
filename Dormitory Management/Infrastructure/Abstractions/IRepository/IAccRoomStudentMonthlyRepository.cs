using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions.IRepository
{
    internal interface IAccRoomStudentMonthlyRepository : IGenericRepository<AccRoomStudentMonthly>
    {
        Task<List<AccRoomStudentMonthly>> GetByStudentId(Guid id);
    }
}
