namespace KooliProjekt.Data.Repositories
{
    public interface IPäevikSisuRepository
    {
        Task<U> Get<U>(int id);
        Task<IList<U>> List<U>();
        Task Save(PäevikSisu task);
        Task Delete(int id);
    }
}
