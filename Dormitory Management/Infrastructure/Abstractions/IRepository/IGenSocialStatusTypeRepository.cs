using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository;

public interface IGenSocialStatusTypeRepository
{
    Task<IEnumerable<GenSocialStatusType>> GetAll();
    Task<GenSocialStatusType> GetById(Guid id);
}
