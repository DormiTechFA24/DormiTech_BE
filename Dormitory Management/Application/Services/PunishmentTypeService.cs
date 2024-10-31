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
    public class PunishmentTypeService : IPunishmentTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PunishmentTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<PunishmentTypeResponse>> GetAll()
        {
            var punishmentTypes = _mapper.Map<List<PunishmentTypeResponse>>(await _unitOfWork.punishmentTypeRepository.GetAll());
            return punishmentTypes;
        }

        public async Task<PunishmentTypeResponse> GetPunishmentTypeById(Guid id)
        {
            var punishmentType = _mapper.Map<PunishmentTypeResponse>(await _unitOfWork.punishmentTypeRepository.GetById(id));
            return punishmentType;
        }
    }

}
