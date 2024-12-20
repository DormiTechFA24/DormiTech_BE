﻿using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenServiceRepository : IGenServiceRepository
    {
        private readonly DbSet<GenService> context;

        public GenServiceRepository(DormiTechContext context)
        {
            this.context = context.Set<GenService>();
        }

        public async Task<IEnumerable<GenService>> GetAll()
        {
            IQueryable<GenService> query = context;

            return query;
        }

        public async Task<GenService> GetById(Guid id)
        {
            IQueryable<GenService> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}