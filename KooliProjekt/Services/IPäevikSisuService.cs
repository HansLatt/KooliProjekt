using KooliProjekt.Models;

namespace KooliProjekt.Services
{
    public interface IPäevikSisuService
    {
        public Task<IList<U>> List<U>();
        public Task<U> Get<U>(int id);
        public Task Save(PäevikSisuModel model);
        public Task Delete(int id);
    }
}
