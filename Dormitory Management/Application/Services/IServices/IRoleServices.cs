using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IRoleServices
    {
        Task<List<SysRole>> GetAll();
        Task<SysRole> GetByID(int id);
    }
}
