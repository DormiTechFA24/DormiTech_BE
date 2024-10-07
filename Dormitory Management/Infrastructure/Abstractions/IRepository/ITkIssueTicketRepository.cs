﻿using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface ITkIssueTicketRepository
{
    Task<IEnumerable<TkIssueTicket>> Get();
    Task<IEnumerable<TkIssueTicket>> Search(
        Guid? ticketOwner,
        DateTime? CreatedOn,
        DateTime? approvedOn,
        int ticketStatusId = 0,
        int ticketTypeId = 0,
        string header = "");
    Task<TkIssueTicket> Detail(Guid id);
    void Create(TkIssueTicket tkIssueTicket);
    void Update(TkIssueTicket tkIssueTicket);
}