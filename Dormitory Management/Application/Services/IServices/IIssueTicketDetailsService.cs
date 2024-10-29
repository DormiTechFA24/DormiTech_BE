using Application.View_Models.RequestModels;
using Application.View_Models.ResponseModels;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IIssueTicketDetailsService
    {
        Task<List<IssueTicketDetailResponse>> GetAll();
        Task<IssueTicketDetailResponse> GetByTicketId(Guid id);
        Task Create(IssueTicketDetailsRequest request);
        Task Delete(IssueTicketDetailsRequest request);
    }
}
