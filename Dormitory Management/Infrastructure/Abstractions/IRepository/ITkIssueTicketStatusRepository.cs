using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository;

public interface ITkIssueTicketStatusRepository
{
    Task<IEnumerable<TkIssueTicketStatus>> GetAll();
    Task<TkIssueTicketStatus> GetById(Guid id);
}
