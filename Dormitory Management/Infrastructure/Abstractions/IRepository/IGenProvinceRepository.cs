using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository;

public interface IGenProvinceRepository
{
    Task<IEnumerable<GenProvince>> GetAll();
    Task<GenProvince> GetById(Guid id);
}
