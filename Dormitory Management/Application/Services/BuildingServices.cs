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
    public class BuildingServices : IBuildingServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BuildingServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<BuidingResponse>> GetAll()
        {
            var building = _mapper.Map<List<BuidingResponse>>(await _unitOfWork.facBuildingRepository.GetAllAsync());
            return building;
        }

        public async Task<BuidingResponse> GetByID(int id)
        {
            var building = _mapper.Map<BuidingResponse>(await _unitOfWork.facBuildingRepository.GetByIdAsync(roomId));
            return building;
        }
    }
}
