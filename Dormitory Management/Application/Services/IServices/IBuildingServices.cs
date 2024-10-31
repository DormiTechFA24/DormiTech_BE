using Application.View_Models.ResponseModels;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IBuildingServices
    {
        Task<List<BuidingResponse>> GetAll();
        Task<BuidingResponse> GetByID(int id);
    }
}
