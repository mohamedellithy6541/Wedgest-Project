using Wedgest.Entities;

namespace Wedgest.Repositories
{
    public interface IGenaricRepository<T> where T : class
    {
        #region signtureofmethods
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Add(T t);
        Task Updated(int id, T t);
        void Delete(int id);
        #endregion
    }
}
