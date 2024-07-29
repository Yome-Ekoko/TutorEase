using AutoMapper;
using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Domain.Entities;

namespace TutorEase.Infrastructure.Configs
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<T_User, AuthenticationResponse>(MemberList.None);
            CreateMap<T_User, UserResponse>(MemberList.None);
            CreateMap<AddUserRequest, T_User>(MemberList.None);
            CreateMap<AddTutorRequest, Tutor>(MemberList.None);
            CreateMap<Tutor, AddTutorResponse>(MemberList.None);
           
        }
    }
}
