using Application.Abstractions;
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
    internal class RoomMonthlyService : IRoomMonthlyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomMonthlyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RoomMonthlyResponse>> GetAll()
        {
            return _mapper.Map<List<RoomMonthlyResponse>>(await _unitOfWork.roomMonthlyRepository.GetAll());
        }

        public async Task<List<RoomMonthlyResponse>> GetByRoomId(Guid id)
        {
            return _mapper.Map<List<RoomMonthlyResponse>>(await _unitOfWork.roomMonthlyRepository.GetByRoomId(id));
        }

        public async Task<List<RoomMonthlyResponse>> GetFromDateToDate(DateTime from, DateTime to)
        {
            return _mapper.Map<List<RoomMonthlyResponse>>(await _unitOfWork.roomMonthlyRepository.GetFromDateToDate(from, to));
        }
    }
}
