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
    public class SocialStatusTypeService : ISocialStatusTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SocialStatusTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<SocialStatusTypeResponse>> GetAll()
        {
            var servicePricings = _mapper.Map<List<SocialStatusTypeResponse>>(await _unitOfWork.socialStatusTypeRepository.GetAll());
            return servicePricings;
        }

        public async Task<SocialStatusTypeResponse> GetSocialStatusTypeById(Guid id)
        {
            var servicePricing = _mapper.Map<SocialStatusTypeResponse>(await _unitOfWork.socialStatusTypeRepository.GetById(id));
            return servicePricing;
        }
    }

}
