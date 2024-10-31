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
    public class ItemStatusService : IItemStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ItemStatusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ItemStatusResponse>> GetAll()
        {
            var itemStatuses = _mapper.Map<List<ItemStatusResponse>>(await _unitOfWork.itemStatusRepository.GetAll());
            return itemStatuses;
        }

        public async Task<ItemStatusResponse> GetItemStatusById(Guid id)
        {
            var itemStatus = _mapper.Map<ItemStatusResponse>(await _unitOfWork.itemStatusRepository.GetById(id));
            return itemStatus;
        }
    }

}
