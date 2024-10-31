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
    public class PayTypeService : IPayTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PayTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<PayTypeResponse>> GetAll()
        {
            var payTypes = _mapper.Map<List<PayTypeResponse>>(await _unitOfWork.payTypeRepository.GetAll());
            return payTypes;
        }

        public async Task<PayTypeResponse> GetPayTypeById(Guid id)
        {
            var payType = _mapper.Map<PayTypeResponse>(await _unitOfWork.payTypeRepository.GetById(id));
            return payType;
        }
    }

}
