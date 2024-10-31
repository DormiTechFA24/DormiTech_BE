using Application.Abstractions;
using Application.Services.IServices;
using Application.View_Models.RequestModels;
using Application.View_Models.ResponseModels;
using AutoMapper;
using Azure.Core;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class IssueTicketPhotoService : IIssueTicketPhotoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IssueTicketPhotoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Create(IssueTicketPhotoRequest request)
        {
            await _unitOfWork.issueTicketPhotoRepository.AddAsync(_mapper.Map<TkIssueTicketPhoto>(request));
        }

        public async Task Delete(IssueTicketPhotoRequest request)
        {
            await _unitOfWork.issueTicketPhotoRepository.DeleteAsync(_mapper.Map<TkIssueTicketPhoto>(request));
        }

        public async Task<List<IssueTicketPhotoResponse>> GetAll()
        {
            return _mapper.Map<List<IssueTicketPhotoResponse>>(await _unitOfWork.issueTicketPhotoRepository.GetAllAsync());
        }

        public async Task<List<IssueTicketPhotoResponse>> GetByTicketId(Guid id)
        {
            return _mapper.Map<List<IssueTicketPhotoResponse>>(await _unitOfWork.issueTicketPhotoRepository.GetByTicketId(id));
        }
    }
}
