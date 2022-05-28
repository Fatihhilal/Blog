using AutoMapper;
using Blog.Application.Models.User;
using Blog.DataAccess.Identity;

namespace Blog.Application.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserModel, ApplicationUser>();
    }
}