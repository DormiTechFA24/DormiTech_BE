using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository;

internal interface IGenRoomStatusRepository
{
    Task<IEnumerable<GenRoomStatus>> GetAll();
    Task<GenRoomStatus> GetById(Guid id);
}
