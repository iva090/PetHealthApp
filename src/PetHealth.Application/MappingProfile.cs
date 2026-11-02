using AutoMapper;
using PetHealth.Business.Models;
using PetHealth.Domain.Entities;

namespace PetHealth.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pet, PetModel>().ReverseMap()
            .ForMember(d => d.OwnerId, o => o.Ignore())
            .ForMember(d => d.CreatedAt, o => o.Ignore());

            CreateMap<DietPlan, DietPlanModel>().ReverseMap()
                .ForMember(d => d.CreatedAt, o => o.Ignore());
        }
    }
}
