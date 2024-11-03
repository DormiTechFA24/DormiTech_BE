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
    public class EmloyeeServices : IEmployeeServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmloyeeServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<EmployeeReponse>> GetAll()
        {
            var employees = _mapper.Map<List<EmployeeReponse>>(await _unitOfWork.employeeRepository.GetAllAsync());
            return employees;
        }

        public async Task<EmployeeReponse> GetByID(Guid id)
        {
            var employees = _mapper.Map<EmployeeReponse>(await _unitOfWork.employeeRepository.GetByGuidIdAsync(id));
            return employees;
        }
    }
}
