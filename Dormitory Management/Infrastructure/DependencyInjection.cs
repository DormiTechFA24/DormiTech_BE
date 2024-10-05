using Domain.Abstractions;
using Domain.Abstractions.IRepository;
using Domain.Model;
using Infrastructure.Repositories;
using Infrastructure.Services.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure
       (this IServiceCollection services)
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true).Build();

        services.AddDbContext<DormiTechContext>
            (options => options.UseSqlServer
            (config.GetConnectionString
            ("DefaultConnectionString")!));

        services.AddDistributedMemoryCache();
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

        return services;
    }
}
