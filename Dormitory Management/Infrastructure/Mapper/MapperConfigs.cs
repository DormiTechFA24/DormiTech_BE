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
        public MapperConfigs()
        {
            #region Add
            AddAccountMapperConfig();
            #endregion
        }
        #region create 
        partial void AddAccountMapperConfig();
        #endregion
    }
}
