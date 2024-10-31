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
        Task<List<AccDisciplineTicket>> GetAll();
        Task<AccDisciplineTicket> GetByID(Guid id);
    }
}
