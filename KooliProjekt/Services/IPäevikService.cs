using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public interface IPäevikService
    {
        public Task<IList<LookupItem>> Lookup();
    }
}
