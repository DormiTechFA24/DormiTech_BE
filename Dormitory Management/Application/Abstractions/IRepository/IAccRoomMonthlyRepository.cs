using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions.IRepository
{
    internal interface IAccRoomMonthlyRepository
    {
        Task<List<AccRoomMonthly>> GetByRoomId(Guid id);
        Task<List<AccRoomMonthly>> GetFromDateToDate(DateTime from, DateTime to);
    }
}
