using AutoMapper;

namespace Infrastructure.Mapper
{
    public partial class MapperConfigs : Profile
    {
        public MapperConfigs()
        {
            #region#region Add

            AddAccountMapperConfig();
            AddRoomMapperConfig();  
            #endregion



        }

        #region create

        partial void AddAccountMapperConfig();
        partial void AddRoomMapperConfig();
        #endregion
    }
}