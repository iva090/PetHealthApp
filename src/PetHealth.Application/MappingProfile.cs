using AutoMapper;
using PetHealth.Business.Models;
using PetHealth.Data.Entities;
using PetHealth.Domain.Entities;

namespace PetHealth.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pet, PetModel>().ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.OwnerId, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore())
                .ForMember(d => d.Vaccines, o => o.Ignore())
                .ForMember(d => d.VetVisits, o => o.Ignore())
                .ForMember(d => d.DietPlans, o => o.Ignore());

            CreateMap<Vaccine, VaccineModel>().ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.PetId, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore());

            CreateMap<VetVisit, VetVisitModel>().ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.PetId, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore());

            CreateMap<DietPlan, DietPlanModel>().ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.PetId, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore());

            CreateMap<ChatMessage, ChatMessageModel>().ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.Pet, o => o.Ignore());
        }
    }
}