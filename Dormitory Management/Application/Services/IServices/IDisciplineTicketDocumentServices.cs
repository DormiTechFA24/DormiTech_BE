using Application.View_Models.ResponseModels;
using Domain.Model;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IDisciplineTicketDocumentServices
    {
        Task<List<DisciplineResponse>> GetAll();
        Task<DisciplineResponse> GetByID(Guid id);
    }
}
