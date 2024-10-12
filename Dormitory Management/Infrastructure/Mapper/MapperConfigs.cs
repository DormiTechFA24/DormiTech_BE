using AutoMapper;

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