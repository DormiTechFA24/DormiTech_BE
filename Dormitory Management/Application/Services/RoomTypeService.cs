using Application.Abstractions;
using Application.Services.IServices;
using Application.View_Models.ResponseModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoomTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RoomTypeResponse>> GetAll()
        {
            var roomTypes = _mapper.Map<List<RoomTypeResponse>>(await _unitOfWork.roomTypeRepository.GetAll());
            return roomTypes;
        }

        public async Task<RoomTypeResponse> GetRoomTypeById(Guid id)
        {
            var roomType = _mapper.Map<RoomTypeResponse>(await _unitOfWork.roomTypeRepository.GetById(id));
            return roomType;
        }
    }


}
