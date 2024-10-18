using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions.IRepository
{
    internal interface ITkIssueTicketPhotoRepository : IGenericRepository<TkIssueTicketPhoto>
    {
        Task<List<TkIssueTicketPhoto>> GetByTicketId(Guid id);
    }
}
