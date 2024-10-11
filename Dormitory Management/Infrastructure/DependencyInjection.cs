using Domain.Abstractions;
using Domain.Abstractions.IRepository;
using Domain.Model;
using Infractstructure.Abstractions.IRepository;
using Infractstructure.Repositories;
using Infrastructure.Mapper;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfractstructure
       (this IServiceCollection services, IConfiguration config)
    {
        IConfigurationRoot configs = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true).Build();

        services.AddDbContext<DormiTechContext>
            (options => options.UseSqlServer
            (configs.GetConnectionString
            ("DormiTech")!));

        services.AddDistributedMemoryCache();

        #region Add Scoped
        services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        services.AddScoped<IBilBillingRepository, BilBillingRepository>();
        services.AddScoped<IFacBuildingRepository, FacBuildingRepository>();
        services.AddScoped<IFacItemRepository, FacItemRepository>();
        services.AddScoped<IFacRoomItemRepository, FacRoomItemRepository>();
        services.AddScoped<IFacRoomRepository, FacRoomRepository>();
        services.AddScoped<IGenStudentRepository, GenStudentRepository>();
        services.AddScoped<ISysAccountRepository, SysAccountRepository>();
        services.AddScoped<ISysPermissionRepository, SysPermissionRepository>();
        services.AddScoped<ISysRoleRepository, SysRoleRepository>();
        services.AddScoped<ITkIssueTicketRepository, TkIssueTicketRepository>();


        services.AddScoped<IGenDocumentRepository, GenDocumentRepository>();
        services.AddScoped<IGenEmployeePositionRepository, GenEmployeePositionRepository>();
        services.AddScoped<IGenEthnicityRepository, GenEthnicityRepository>();
        services.AddScoped<IGenItemStatusRepository, GenItemStatusRepository>();
        services.AddScoped<IGenModuleTypeRepository, GenModuleTypeRepository>();
        services.AddScoped<IGenPayTypeRepository, GenPayTypeRepository>();

        #endregion

        // Use local DB
        //services.AddDbContext<DormiTechContext>(opt => opt.UseSqlServer(config.GetConnectionString("DormiTechDB")));
        services.AddAutoMapper(typeof(MapperConfigs).Assembly);

        return services;
    }
}
