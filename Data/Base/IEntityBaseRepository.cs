using enTicket.Models;
using System.Linq.Expressions;

namespace enTicket.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIDAsync(int id);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
        Task AddAsync(T entity);

    }
}
