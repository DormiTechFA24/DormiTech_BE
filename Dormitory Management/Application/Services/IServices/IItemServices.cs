using Application.View_Models.ResponseModels;
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
        Task<List<ItemResponse>> GetAll();
        Task<ItemResponse> GetByID(int id);
    }
}
