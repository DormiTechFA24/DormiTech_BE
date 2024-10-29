using Application.View_Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IIssueTicketStatusService
    {
        Task<List<IssueTicketStatusResponse>> GetAll();
        Task<IssueTicketStatusResponse> GetIssueTicketStatusById(Guid id);
    }
}
