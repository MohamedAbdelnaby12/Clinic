namespace Clinic.DAL.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        //added
        Task<T> GetByIdAsync(int Id);
    }
}
