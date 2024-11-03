using Application.ResponseModels;
using Application.View_Models.ResponseModels;
using AutoMapper;
using Domain.Model;

namespace Infrastructure.Mapper
{
    public partial class MapperConfigs : Profile
    {
        public MapperConfigs()
        {
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
            CreateMap<FacBuilding, BuidingResponse>().ReverseMap();
            CreateMap<FacItem, ItemResponse>().ReverseMap();
            CreateMap<FacRoom, RoomResponse>().ReverseMap();
            CreateMap<GenAmenity, AmenityResponse>().ReverseMap();
            CreateMap<FacRoomItem, RoomItemResponse>().ReverseMap();
            CreateMap<SysRole, RoleResponse>().ReverseMap();
            CreateMap<GenEmployee, EmployeeReponse>().ReverseMap();
            CreateMap<AccDisciplineTicket, DisciplineResponse>().ReverseMap();
            CreateMap<AccDisciplineTicketDocument, DisciplineTecketDocuimentReponse>().ReverseMap();

        }
    }
}