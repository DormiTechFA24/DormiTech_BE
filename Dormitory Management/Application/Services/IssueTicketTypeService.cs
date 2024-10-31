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
    public class IssueTicketTypeService : IIssueTicketTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public IssueTicketTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<IssueTicketTypeResponse>> GetAll()
        {
            var itemStatuses = _mapper.Map<List<IssueTicketTypeResponse>>(await _unitOfWork.issueTicketTypeRepository.GetAll());
            return itemStatuses;
        }

        public async Task<IssueTicketTypeResponse> GetIssueTicketTypeById(Guid id)
        {
            var itemStatus = _mapper.Map<IssueTicketTypeResponse>(await _unitOfWork.issueTicketTypeRepository.GetById(id));
            return itemStatus;
        }
    }

}
