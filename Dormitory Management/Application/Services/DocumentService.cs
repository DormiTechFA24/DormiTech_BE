using Application.Abstractions;
using Application.RequestModels;
using Application.ResponseModels;
using Application.Services.IServices;
using Application.View_Models.ResponseModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DocumentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DocumentResponse>> GetAll()
        {
            var documents = _mapper.Map<List<DocumentResponse>>(await _unitOfWork.documentRepository.GetAll());
            return documents;
        }

        public async Task<DocumentResponse> GetDocumentId(Guid id)
        {
            var document = _mapper.Map<DocumentResponse>(await _unitOfWork.documentRepository.GetById(id));
            return document;
        }
    }
}
