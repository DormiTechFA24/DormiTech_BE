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
    public class RoomStatusService : IRoomStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoomStatusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RoomStatusResponse>> GetAll()
        {
            var roomStatuses = _mapper.Map<List<RoomStatusResponse>>(await _unitOfWork.roomStatusRepository.GetAll());
            return roomStatuses;
        }

        public async Task<RoomStatusResponse> GetRoomStatusById(Guid id)
        {
            var roomStatus = _mapper.Map<RoomStatusResponse>(await _unitOfWork.roomStatusRepository.GetById(id));
            return roomStatus;
        }
    }

}
