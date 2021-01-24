using AutoMapper;
using LastTry.Domain.Models;
using LastTry.Resources;

namespace LastTry.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}