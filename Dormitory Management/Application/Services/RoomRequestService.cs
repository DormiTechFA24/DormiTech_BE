using Application.Abstractions;
using Application.Services.IServices;
using Application.View_Models.RequestModels;
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
    internal class RoomRequestService : IRoomRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomRequestService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Create(RoomReqRequest request)
        {
            await _unitOfWork.roomRequestRepository.AddAsync(_mapper.Map<AccRoomRequest>(request));
        }

        public async Task Delete(RoomReqRequest request)
        {
            await _unitOfWork.roomRequestRepository.DeleteAsync(_mapper.Map<AccRoomRequest>(request));
        }

        public async Task<List<RoomRequestResponse>> GetAll()
        {
            return _mapper.Map<List<RoomRequestResponse>>(await _unitOfWork.roomRequestRepository.GetAllAsync());
        }

        public async Task<RoomRequestResponse> GetById(int id)
        {
            return _mapper.Map<RoomRequestResponse>(await _unitOfWork.roomRequestRepository.GetByIdAsync(id));
        }

        public async Task<List<RoomRequestResponse>> GetByStudentId(Guid id)
        {
            return _mapper.Map<List<RoomRequestResponse>>(await _unitOfWork.roomRequestRepository.GetByStudentId(id));
        }

        public async Task<List<RoomRequestResponse>> GetFromDateToDate(DateTime from, DateTime to)
        {
            return _mapper.Map<List<RoomRequestResponse>>(await _unitOfWork.roomRequestRepository.GetFromDateToDate(from, to));
        }
    }
}