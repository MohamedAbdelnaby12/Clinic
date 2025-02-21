using System.Linq.Expressions;
using System.Xml;
using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepository;
using Clinic.DAL.Repository.Abstract;
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
            await _clinicDb.SaveChangesAsync();
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

      

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _entity.FirstOrDefaultAsync(predicate);
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
