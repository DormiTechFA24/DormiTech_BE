using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IEmployeeServices
    {
        Task<List<GenEmployee>> GetAll();
        Task<GenEmployee> GetByID(Guid id);
    }
}
