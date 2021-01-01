using AutoMapper;
using Library.Data;
using Library.Models;

namespace Library.Mappings
{
    public class AutoMappings : Profile
    {
        public AutoMappings()
        {
            CreateMap<ApplicationUser, UserReturnedModel>();
        }
    }
}
