using Clinic.DAL.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ClinicDbContext _clinicDb;
        private DbSet<T> _entity;
        public GenericRepository(ClinicDbContext clinicDbContext)
        {
            _clinicDb = clinicDbContext;
            _entity = _clinicDb.Set<T>();

        }
        public async Task<T> AddAsync(T entity)
        {
            await _entity.AddAsync(entity);
            _clinicDb.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _entity.Remove(entity);
            await _clinicDb.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _entity.FindAsync(Id);
        }

        public async Task UpdateAsync(T entity)
        {
            _entity.Update(entity);
            await _clinicDb.SaveChangesAsync();
        }
    }
}
