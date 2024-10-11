using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository;

public interface IGenServicePricingRepository
{
    Task<IEnumerable<GenServicePricing>> GetAll();
    Task<GenServicePricing> GetById(Guid id);
}
