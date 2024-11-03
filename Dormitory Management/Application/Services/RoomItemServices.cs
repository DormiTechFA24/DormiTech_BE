using Application.Abstractions;
using Application.ResponseModels;
using Application.Services.IServices;
using Application.View_Models.ResponseModels;
using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RoomItemServices : IRoomItemServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomItemServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<RoomItemResponse>> GetAll()
        {
            var roomitem = _mapper.Map<List<RoomItemResponse>>(await _unitOfWork.facRoomItemRepository.GetAllAsync());
            return roomitem;
        }

        public async Task<RoomItemResponse> GetByID(int id)
        {
            var roomitem = _mapper.Map<RoomItemResponse>(await _unitOfWork.facRoomItemRepository.GetByIdAsync(id));
            return roomitem;
        }
    }
}
