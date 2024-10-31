using Application.View_Models.RequestModels;
using Application.View_Models.ResponseModels;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IRoomRequestService
    {
        Task<List<RoomRequestResponse>> GetAll();
        Task<RoomRequestResponse> GetById(int id);
        Task<List<RoomRequestResponse>> GetByStudentId(Guid id);
        Task<List<RoomRequestResponse>> GetFromDateToDate(DateTime from, DateTime to);
        Task Create(RoomReqRequest request);
        Task Delete(RoomReqRequest request);
    }
}
