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
    public class DisciplineTicketDocumentServices : IDisciplineTicketDocumentServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DisciplineTicketDocumentServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<DisciplineResponse>> GetAll()
        {
            var ticket = _mapper.Map<List<DisciplineResponse>>(await _unitOfWork.accDisciplineTicketRepository.GetAllAsync());
            return ticket;
        }

        public async Task<DisciplineResponse> GetByID(Guid id)
        {
            var ticket = _mapper.Map<DisciplineResponse>(await _unitOfWork.accDisciplineTicketRepository.GetByGuidIdAsync(id));
            return ticket;
        }
    }
}
