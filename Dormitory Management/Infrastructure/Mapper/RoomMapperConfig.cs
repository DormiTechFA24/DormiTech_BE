using Application.RequestModels;
using Application.ResponseModels;
using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapper
{
    public partial class MapperConfigs : Profile
    {
        partial void AddRoomMapperConfig()
        {
            CreateMap<FacRoom, RoomResponse>()
                .ReverseMap();
            CreateMap<FacRoom, RoomRequest>().ReverseMap();
        }
    }
}
