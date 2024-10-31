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
    public class AmenityServices : IAmenityServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AmenityServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<List<AmenityResponse>> GetAll()
        {
            var amenities = _mapper.Map<List<AmenityResponse>>(await _unitOfWork..GetAllAsync());
            return amenities;
        }

        public Task<AmenityResponse> GetByID(int id)
        {
            var room = _mapper.Map<AmenityResponse>(await _unitOfWork.roomRepository.GetByIdAsync(roomId));
            return room;
        }
    }
}
