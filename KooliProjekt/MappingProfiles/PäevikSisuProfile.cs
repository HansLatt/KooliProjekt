using AutoMapper;
using KooliProjekt.Data;
using KooliProjekt.Models;

namespace KooliProjekt.MappingProfiles
{
    public class PäevikSisuProfile : Profile
    {
        public PäevikSisuProfile() 
        {
            CreateMap<PäevikSisu, PäevikSisuListModel>();
            CreateMap<PäevikSisu, PäevikSisuModel>();

            CreateMap<PäevikSisuModel, PäevikSisu>()
                .ForMember(m => m.Id, m => m.Ignore())
                .ForMember(m => m.Päevik, m => m.Ignore());
        }
    }
}
