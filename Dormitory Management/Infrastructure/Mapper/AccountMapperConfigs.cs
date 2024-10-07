using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
