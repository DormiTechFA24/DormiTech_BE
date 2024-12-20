﻿using Application.Services.IServices;
using Domain.Model;
using Application.Abstractions.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AccDisciplineTicketPunishmentRepository : GenericRepository<TkIssueTicketPhoto>, IAccDisciplineTicketPunishmentRepository
    {
        public AccDisciplineTicketPunishmentRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
