using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.IServices
{
    public interface IDisciplineTicketServices
    {
        Task<List<AccDisciplineTicketDocument>> GetAll();
        Task<AccDisciplineTicketDocument> GetByID(Guid id);
    }
}
