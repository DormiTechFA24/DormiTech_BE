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
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StudentResponse>> GetAll()
        {
            var servicePricings = _mapper.Map<List<StudentResponse>>(await _unitOfWork.studentRepository.GetAllAsync());
            return servicePricings;
        }

        public async Task<StudentResponse> GetStudentById(int id)
        {
            var servicePricing = _mapper.Map<StudentResponse>(await _unitOfWork.studentRepository.GetByIdAsync(id));
            return servicePricing;
        }
    }
}
