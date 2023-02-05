using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data.Repositories
{
    public class PäevikRepository : IPäevikRepository
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly IMapper _objectMapper;

        public PäevikRepository(ApplicationDbContext dataContext, IMapper objectMapper)
        {
            _dataContext = dataContext;
            _objectMapper = objectMapper;
        }

        public async Task<U> Get<U>(int id)
        {
            return await _dataContext.Päevik
                                     .Where(päevik => päevik.Id == id)
                                     .ProjectTo<U>(_objectMapper.ConfigurationProvider)
                                     .FirstOrDefaultAsync();
        }
    }
}