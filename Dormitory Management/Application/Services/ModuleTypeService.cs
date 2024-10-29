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
    public class ModuleTypeService : IModuleTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ModuleTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ModuleTypeResponse>> GetAll()
        {
            var moduleTypes = _mapper.Map<List<ModuleTypeResponse>>(await _unitOfWork.moduleTypeRepository.GetAll());
            return moduleTypes;
        }

        public async Task<ModuleTypeResponse> GetModuleTypeById(Guid id)
        {
            var moduleType = _mapper.Map<ModuleTypeResponse>(await _unitOfWork.moduleTypeRepository.GetById(id));
            return moduleType;
        }
    }

}
