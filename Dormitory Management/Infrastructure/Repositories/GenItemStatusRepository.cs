﻿using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenItemStatusRepository : IGenItemStatusRepository
    {
        private readonly DbSet<GenItemStatus> context;

        public GenItemStatusRepository(DormiTechContext context)
        {
            this.context = context.Set<GenItemStatus>();
        }

        public async Task<IEnumerable<GenItemStatus>> GetAll()
        {
            IQueryable<GenItemStatus> query = context;

            return query;
        }

        public async Task<GenItemStatus> GetById(Guid id)
        {
            IQueryable<GenItemStatus> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}