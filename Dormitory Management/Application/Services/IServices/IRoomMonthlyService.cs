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
    public interface IRoomMonthlyService
    {
        Task<List<RoomMonthlyResponse>> GetAll();
        Task<List<RoomMonthlyResponse>> GetByRoomId(Guid id);
        Task<List<RoomMonthlyResponse>> GetFromDateToDate(DateTime from, DateTime to);
    }
}
