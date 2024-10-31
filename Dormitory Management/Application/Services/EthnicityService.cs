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
    public class EthnicityService : IEthnicityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EthnicityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<EthnicityResponse>> GetAll()
        {
            var ethnicities = _mapper.Map<List<EthnicityResponse>>(await _unitOfWork.ethnicityRepository.GetAll());
            return ethnicities;
        }

        public async Task<EthnicityResponse> GetEthnicityById(Guid id)
        {
            var ethnicity = _mapper.Map<EthnicityResponse>(await _unitOfWork.ethnicityRepository.GetById(id));
            return ethnicity;
        }
    }

}
