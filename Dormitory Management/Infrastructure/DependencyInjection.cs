using Application.Services;
using Application.Services.IServices;
using Application.Abstractions;
using Domain.Model;
using Application.Abstractions.IRepository;
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
        //IConfigurationRoot configs = new ConfigurationBuilder()
        //    .SetBasePath(Directory.GetCurrentDirectory())
        //    .AddJsonFile("appsettings.json", true, true).Build();

        //services.AddDbContext<DormiTechContext>
        //(options => options.UseSqlServer
        //(configs.GetConnectionString
        //    ("DormiTechDB")!));

        services.AddDistributedMemoryCache();

        #region Add Scoped Repository

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
        services.AddScoped<IGenProvinceRepository, GenProvinceRepository>();
        services.AddScoped<IGenPunishmentTypeRepository, GenPunishmentTypeRepository>();
        services.AddScoped<IGenRoomStatusRepository, GenRoomStatusRepository>();
        services.AddScoped<IGenServiceRepository, GenServiceRepository>();
        services.AddScoped<IGenServicePricingRepository, GenServicePricingRepository>();
        services.AddScoped<IGenRoomTypeRepository, GenRoomTypeRepository>();
        services.AddScoped<IGenSocialStatusTypeRepository, GenSocialStatusTypeRepository>();
        services.AddScoped<IGenWardRepository, GenWardRepository>();
        services.AddScoped<ITkIssueTicketTypeRepository, TkIssueTicketTypeRepository>();
        services.AddScoped<ITkIssueTicketStatusRepository, TkIssueTicketStatusRepository>();

        services.AddScoped<IFacBuildingRepository, FacBuildingRepository>();
        services.AddScoped<IFacItemRepository, FacItemRepository>();
        services.AddScoped<IFacRoomRepository, FacRoomRepository>();
        services.AddScoped<IGenAmenityRepository, GenAmenityRepository>();
        services.AddScoped<IFacRoomAmenityRepository, FacRoomAmentityRepository>();
        services.AddScoped<IFacRoomItemRepository, FacRoomItemRepository>();
        services.AddScoped<ISysAccountRoleRepository, SysAccountRoleRepository>();
        services.AddScoped<ISysRoleRepository, SysRoleRepository>();
        services.AddScoped<IGenEmployeeRepository, GenEmployeeRepository>();
        services.AddScoped<IGenStudentRepository, GenStudentRepository>();
        services.AddScoped<ISysAccountRepository, SysAccountRepository>();
        services.AddScoped<IAccDisciplineTicketRepository, AccDisciplineTicketRepository>();
        services.AddScoped<IAccDisciplineTicketDocumentRepository, AccDisciplineTicketDocumentRepository>();
        services.AddScoped<IAccDisciplineTicketPunishmentRepository, AccDisciplineTicketPunishmentRepository>();

        services.AddScoped<ITkIssueTicketDetailRepository, TkIssueTicketDetailRepository>();
        services.AddScoped<ITkIssueTicketPhotoRepository, TkIssueTicketPhotoRepository>();
        services.AddScoped<IAccRoomRequestRepository, AccRoomRequestRepository>();
        services.AddScoped<IAccRoomMonthlyRepository, AccRoomMonthlyRepository>();
        services.AddScoped<IAccRoomStudentMonthlyRepository, AccRoomStudentMonthlyRepository>();

        #endregion
        #region AddScoped Services
        services.AddTransient<IRoomServices, RoomServices>();

        #endregion
        // Use local DB
        services.AddDbContext<DormiTechContext>(opt => opt.UseSqlServer(config.GetConnectionString("DormiTechDB")));
        services.AddAutoMapper(typeof(MapperConfigs).Assembly);

        return services;
    }
}