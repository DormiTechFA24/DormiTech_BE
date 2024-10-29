using Application.View_Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IStudentService
    {
        Task<List<StudentResponse>> GetAll();
        Task<StudentResponse> GetStudentById(int id);
    }
}
