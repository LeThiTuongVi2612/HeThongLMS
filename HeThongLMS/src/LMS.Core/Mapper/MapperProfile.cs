using AutoMapper;
using LMS.Core.Entities;
using LMS.Core.Mapper.ViewModel;

namespace LMS.Core.Mapper
{
    public class MapperProfile
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<User, UserModel>().ReverseMap();
            }
        }
    }
}
