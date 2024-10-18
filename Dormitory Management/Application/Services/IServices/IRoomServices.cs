using Application.RequestModels;
using Application.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IRoomServices
    {
        Task<RoomResponse> GetRoomById(int roomId);
        Task<List<RoomResponse>> GetAll();
        Task<RoomResponse> Update(RoomRequest room);
        Task<RoomResponse> Create(RoomRequest room);
        Task<bool> Delete(int roomId);
    }
}
