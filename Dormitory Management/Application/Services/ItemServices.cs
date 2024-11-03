using Application.Abstractions;
using Application.ResponseModels;
using Application.Services.IServices;
using Application.View_Models.ResponseModels;
using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ItemServices : IItemServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ItemServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<ItemResponse>> GetAll()
        {
            var item = _mapper.Map<List<ItemResponse>>(await _unitOfWork.facItemRepository.GetAllAsync());
            return item;
        }

        public async Task<ItemResponse> GetByID(int id)
        {
            var item = _mapper.Map<ItemResponse>(await _unitOfWork.facItemRepository.GetByIdAsync(id));
            return item;
        }
    }
}
