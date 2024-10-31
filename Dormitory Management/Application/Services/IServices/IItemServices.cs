using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IItemServices
    {
        Task<List<FacItem>> GetAll();
        Task<FacItem> GetByID(int id);
    }
}
