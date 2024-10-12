using AutoMapper;

namespace Infrastructure.Mapper
{
    public partial class MapperConfigs : Profile
    {
        partial void AddAccountMapperConfig()
        {
            // CreateKMap<Class,Response/RequestModel>();
        }
    }
}