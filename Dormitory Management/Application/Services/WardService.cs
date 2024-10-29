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
    public class WardService : IWardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WardService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<WardResponse>> GetAll()
        {
            var servicePricings = _mapper.Map<List<WardResponse>>(await _unitOfWork.wardRepository.GetAll());
            return servicePricings;
        }

        public async Task<WardResponse> GetWardById(Guid id)
        {
            var servicePricing = _mapper.Map<WardResponse>(await _unitOfWork.wardRepository.GetById(id));
            return servicePricing;
        }
    }
}
