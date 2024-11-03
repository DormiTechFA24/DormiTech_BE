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
    public class DisciplineTicketServices : IDisciplineTicketServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DisciplineTicketServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<DisciplineTecketDocuimentReponse>> GetAll()
        {
            var reponses = _mapper.Map<List<DisciplineTecketDocuimentReponse>>(await _unitOfWork.accDisciplineTicketDocumentRepository.GetAllAsync());
            return reponses;
        }

        public async Task<DisciplineTecketDocuimentReponse> GetByID(Guid id)
        {
            var reponses = _mapper.Map<DisciplineTecketDocuimentReponse>(await _unitOfWork.accDisciplineTicketDocumentRepository.GetByGuidIdAsync(id));
            return reponses;
        }
    }
}
