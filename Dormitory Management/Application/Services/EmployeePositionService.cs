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
    public class EmployeePositionService : IEmployeePositionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeePositionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<EmployeePositionResponse>> GetAll()
        {
            var employeePositions = _mapper.Map<List<EmployeePositionResponse>>(await _unitOfWork.employeePositionRepository.GetAll());
            return employeePositions;
        }

        public async Task<EmployeePositionResponse> GetEmployeePositionById(Guid id)
        {
            var employeePosition = _mapper.Map<EmployeePositionResponse>(await _unitOfWork.employeePositionRepository.GetById(id));
            return employeePosition;
        }
    }

}
