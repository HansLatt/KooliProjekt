using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public class PäevikService : IPäevikService
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly IMapper _objectMapper;

        public PäevikService(ApplicationDbContext dataContext,
                                  IMapper objectMapper)
        {
            _dataContext = dataContext;
            _objectMapper = objectMapper;
        }

        public async Task<IList<LookupItem>> Lookup()
        {
            return await _dataContext.Päevik
                                     .OrderBy(p => p.Date)
                                     .ProjectTo<LookupItem>(_objectMapper.ConfigurationProvider)
                                     .ToListAsync();
        }
    }
}
