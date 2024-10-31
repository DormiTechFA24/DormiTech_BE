using Application.View_Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IDocumentService
    {
        Task<List<DocumentResponse>> GetAll();
        Task<DocumentResponse> GetDocumentId(Guid id);
    }
}
