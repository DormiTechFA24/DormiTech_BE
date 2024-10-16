using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions.IRepository
{
    internal interface IAccRoomRequestRepository : IGenericRepository<AccRoomRequest>
    {
        Task<List<AccRoomRequest>> GetByStudentId(Guid id);
        Task<List<AccRoomRequest>> GetFromDateToDate(DateTime from, DateTime to);
    }
}
