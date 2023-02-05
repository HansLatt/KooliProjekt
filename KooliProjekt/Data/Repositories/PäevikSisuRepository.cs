using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data.Repositories
{
    public class PäevikSisuRepository : IPäevikSisuRepository
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly IMapper _objectMapper;

        public PäevikSisuRepository(ApplicationDbContext dataContext, IMapper objectMapper)
        {
            _dataContext = dataContext;
            _objectMapper = objectMapper;
        }

        public async Task<U> Get<U>(int id)
        {
            return await _dataContext.PäevikSisu
                                     .Include(task => task.Päevik)
                                     .Where(task => task.Id == id)
                                     .ProjectTo<U>(_objectMapper.ConfigurationProvider)
                                     .FirstOrDefaultAsync();
        }

        public async Task<IList<U>> List<U>()
        {
            return await _dataContext.PäevikSisu
                                     .Include(task => task.Päevik)
                                     .OrderByDescending(task => task.Harjutus)
                                     .ProjectTo<U>(_objectMapper.ConfigurationProvider)
                                     .ToListAsync();
        }

        public async Task Save(PäevikSisu task)
        {
            if (task.Id == 0)
            {
                _dataContext.PäevikSisu.Add(task);
            }

            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var task = await _dataContext.PäevikSisu.FindAsync(id);
            if (task == null)
            {
                return;
            }

            _dataContext.PäevikSisu.Remove(task);
            await _dataContext.SaveChangesAsync();
        }
    }
}