using AutoMapper;
using KooliProjekt.Data;
using KooliProjekt.Data.Repositories;
using KooliProjekt.Models;

namespace KooliProjekt.Services
{
    public class PäevikSisuService : IPäevikSisuService
    {
        private readonly IPäevikRepository _päevikRepository;
        private readonly IPäevikSisuRepository _päevikSisuRepository;
        private readonly IMapper _objectMapper;

        public PäevikSisuService(IPäevikRepository päevikRepository,
                                  IPäevikSisuRepository päevikSisuRepository,
                                  IMapper objectMapper)
        {
            _objectMapper = objectMapper;
            _päevikRepository = päevikRepository;
            _päevikSisuRepository = päevikSisuRepository;
        }

        public async Task<IList<U>> List<U>()
        {
            return await _päevikSisuRepository.List<U>();
        }

        public async Task<U> Get<U>(int id)
        {
            return await _päevikSisuRepository.Get<U>(id);
        }

        public async Task Save(PäevikSisuModel model)
        {
            var task = new PäevikSisu();
            if (model.Id != 0)
            {
                task = await _päevikSisuRepository.Get<PäevikSisu>(model.Id);
            }

            _objectMapper.Map(model, task);

            task.Päevik = await _päevikRepository.Get<Päevik>(model.PäevikId);

            await _päevikSisuRepository.Save(task);
        }

        public async Task Delete(int id)
        {
            await _päevikSisuRepository.Delete(id);
        }
    }
}
