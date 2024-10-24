﻿using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public sealed class FacBuildingRepository : GenericRepository<FacBuilding>, IFacBuildingRepository
{
    #region ....
    //private readonly DbSet<FacBuilding> context;

    //public FacBuildingRepository(DormiTechContext context)
    //{
    //    this.context = context.Set<FacBuilding>();
    //}

    //public void Create(FacBuilding facBuilding)
    //{
    //    context.Add(facBuilding);
    //}

    //public void Delete(int Id)
    //{
    //    context
    //        .Where(b => b.BuildingId == Id)
    //        .ExecuteDelete();
    //}

    //public async Task<IEnumerable<FacBuilding>> Get()
    //{
    //    IQueryable<FacBuilding> query = context;

    //    return query;
    //}

    //public async Task<IEnumerable<FacBuilding>> Search(string name)
    //{
    //    IQueryable<FacBuilding> query = context;

    //    return query;
    //}

    //public void Update(FacBuilding facBuilding)
    //{
    //    context.Update(facBuilding);
    //}
    #endregion
    public FacBuildingRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }

}