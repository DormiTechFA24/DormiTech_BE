using Application.Abstractions;
using Application.ResponseModels;
using Application.Services.IServices;
using Application.View_Models.ResponseModels;
using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RoleServices : IRoleServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoleServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<RoleResponse>> GetAll()
        {
            var role = _mapper.Map<List<RoomResponse>>(await _unitOfWork.sysRoleRepository.GetAllAsync());
            return role;
        }

        public async Task<RoleResponse> GetByID(int id)
        {
            var role = _mapper.Map<RoomResponse>(await _unitOfWork.sysRoleRepository.GetByIdAsync(id));
            return role;
        }
    }
}
