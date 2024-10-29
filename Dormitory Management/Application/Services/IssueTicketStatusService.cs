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
    public class IssueTicketStatusService : IIssueTicketStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IssueTicketStatusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<IssueTicketStatusResponse>> GetAll()
        {
            return _mapper.Map<List<IssueTicketStatusResponse>>(await _unitOfWork.issueTicketStatusRepository.GetAll());
        }

        public async Task<IssueTicketStatusResponse> GetIssueTicketStatusById(Guid id)
        {
            return _mapper.Map<IssueTicketStatusResponse>(await _unitOfWork.issueTicketStatusRepository.GetAll());
        }
    }
}
