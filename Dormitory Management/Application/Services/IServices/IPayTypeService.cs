using Application.View_Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IPayTypeService
    {
        Task<List<PayTypeResponse>> GetAll();
        Task<PayTypeResponse> GetPayTypeById(Guid id);
    }
}
