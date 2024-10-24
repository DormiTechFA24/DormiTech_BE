﻿using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenProvinceRepository : IGenProvinceRepository
    {
        private readonly DbSet<GenProvince> context;

        public GenProvinceRepository(DormiTechContext context)
        {
            this.context = context.Set<GenProvince>();
        }

        public async Task<IEnumerable<GenProvince>> GetAll()
        {
            IQueryable<GenProvince> query = context;

            return query;
        }

        public async Task<GenProvince> GetById(Guid id)
        {
            IQueryable<GenProvince> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}