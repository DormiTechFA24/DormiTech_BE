using Application.View_Models.ResponseModels;
using AutoMapper;
using Domain.Model;
using System.Reflection.Metadata;

namespace Infrastructure.Mapper
{
    public partial class MapperConfigs : Profile
    {
        partial void AddAccountMapperConfig()
        {
            // CreateKMap<Class,Response/RequestModel>();
            CreateMap<GenDocument, DocumentResponse>();
            CreateMap<GenEmployeePosition, EmployeePositionResponse>();
            CreateMap<GenEthnicity, EthnicityResponse>();
            CreateMap<GenItemStatus, ItemStatusResponse>();
            CreateMap<GenModuleType, ModuleTypeResponse>();
            CreateMap<GenPayType, PayTypeResponse>();
            CreateMap<GenProvince, ProvinceResponse>();
            CreateMap<GenPunishmentType, PunishmentTypeResponse>();
            CreateMap<GenRoomStatus, RoomStatusResponse>();
            CreateMap<GenRoomType, RoomTypeResponse>();
            CreateMap<GenService, ServiceResponse>();
            CreateMap<GenServicePricing, ServicePricingResponse>();
            CreateMap<GenSocialStatusType, SocialStatusTypeResponse>();
            CreateMap<GenStudent, StudentResponse>();
            CreateMap<GenWard, WardResponse>();
            CreateMap<TkIssueTicketType, IssueTicketTypeResponse>();
            CreateMap<TkIssueTicketStatus, IssueTicketStatusResponse>();
            CreateMap<TkIssueTicketDetail, IssueTicketDetailResponse>();
            CreateMap<TkIssueTicketPhoto, IssueTicketPhotoResponse>();
            CreateMap<AccRoomRequest, RoomRequestResponse>();
            CreateMap<AccRoomMonthly, RoomMonthlyResponse>();
            CreateMap<AccRoomStudentMonthly, RoomStudentMonthlyResponse>();
        }
    }
}