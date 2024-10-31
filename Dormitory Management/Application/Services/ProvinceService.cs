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
    public class ProvinceService : IProvinceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProvinceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ProvinceResponse>> GetAll()
        {
            var provinces = _mapper.Map<List<ProvinceResponse>>(await _unitOfWork.provinceRepository.GetAll());
            return provinces;
        }

        public async Task<ProvinceResponse> GetProvinceById(Guid id)
        {
            var province = _mapper.Map<ProvinceResponse>(await _unitOfWork.provinceRepository.GetById(id));
            return province;
        }
    }

}
