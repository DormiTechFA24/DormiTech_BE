using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository;

public interface IGenEmployeePositionRepository
{
    Task<IEnumerable<GenEmployeePosition>> GetAll();
    Task<GenEmployeePosition> GetById(Guid id);
}
