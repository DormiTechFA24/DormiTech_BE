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
    internal class RoomStudentMonthlyService : IRoomStudentMonthlyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomStudentMonthlyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RoomStudentMonthlyResponse>> GetAll()
        {
            return _mapper.Map<List<RoomStudentMonthlyResponse>>(await _unitOfWork.roomStudentMonthlyRepository.GetAllAsync());
        }

        public async Task<List<RoomStudentMonthlyResponse>> GetByStudentId(Guid id)
        {
            return _mapper.Map<List<RoomStudentMonthlyResponse>>(await _unitOfWork.roomStudentMonthlyRepository.GetByStudentId(id));
        }
    }
}
