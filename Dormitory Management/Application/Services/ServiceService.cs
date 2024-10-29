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
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse>> GetAll()
        {
            var services = _mapper.Map<List<ServiceResponse>>(await _unitOfWork.serviceRepository.GetAll());
            return services;
        }

        public async Task<ServiceResponse> GetServiceById(Guid id)
        {
            var service = _mapper.Map<ServiceResponse>(await _unitOfWork.serviceRepository.GetById(id));
            return service;
        }
    }

}
