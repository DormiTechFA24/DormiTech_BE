using Application.Abstractions;
using Application.ResponseModels;
using Application.Services.IServices;
using Application.View_Models.RequestModels;
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
    internal class IssueTicketDetailsService : IIssueTicketDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IssueTicketDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Create(IssueTicketDetailsRequest request)
        {
            await _unitOfWork.issueTicketDetailRepository.AddAsync(_mapper.Map<TkIssueTicketDetail>(request));
        }

        public async Task Delete(IssueTicketDetailsRequest request)
        {
            await _unitOfWork.issueTicketDetailRepository.DeleteAsync(_mapper.Map<TkIssueTicketDetail>(request));
        }

        public async Task<List<IssueTicketDetailResponse>> GetAll()
        {
            return _mapper.Map<List<IssueTicketDetailResponse>>(await _unitOfWork.issueTicketDetailRepository.GetAllAsync());
        }

        public async Task<IssueTicketDetailResponse> GetByTicketId(Guid id)
        {
            return _mapper.Map<IssueTicketDetailResponse>(await _unitOfWork.issueTicketDetailRepository.GetByTicketId(id));
        }
    }
}
