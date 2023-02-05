namespace KooliProjekt.Data.Repositories
{
    public interface IPäevikRepository
    {
        Task<U> Get<U>(int id);
    }
}
