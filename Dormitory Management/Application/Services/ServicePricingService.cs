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
    public class ServicePricingService : IServicePricingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServicePricingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ServicePricingResponse>> GetAll()
        {
            var servicePricings = _mapper.Map<List<ServicePricingResponse>>(await _unitOfWork.servicePricingRepository.GetAll());
            return servicePricings;
        }

        public async Task<ServicePricingResponse> GetServicePricingById(Guid id)
        {
            var servicePricing = _mapper.Map<ServicePricingResponse>(await _unitOfWork.servicePricingRepository.GetById(id));
            return servicePricing;
        }
    }


}
