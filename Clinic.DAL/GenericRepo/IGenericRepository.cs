using Clinic.DAL.Entities;
using System.Linq.Expressions;

namespace Clinic.DAL.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int Id);
        //added
        Task<T> GetByIdAsync(int Id);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);


    }
}
