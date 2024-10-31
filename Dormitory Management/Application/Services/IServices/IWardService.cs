using Application.View_Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IWardService
    {
        Task<List<WardResponse>> GetAll();
        Task<WardResponse> GetWardById(Guid id);
    }
}
