using AutoMapper;
using KooliProjekt.Data;

namespace KooliProjekt.MappingProfiles
{
    public class PäevikProfile : Profile
    {
        public PäevikProfile()
        {
            CreateMap<Päevik, LookupItem>()
                .ForMember(m => m.DisplayName, m => m.MapFrom(p => p.Date));
        }
    }
}
