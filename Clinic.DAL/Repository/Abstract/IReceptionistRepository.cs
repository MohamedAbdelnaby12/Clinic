using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepository;

namespace Clinic.DAL.Repository.Abstract
{
    public interface IReceptionistRepository : IGenericRepository<Receptionist>
    {
        public  Task<bool> AddReceptionistAndUserAsync(string name, string phone, string email, string password);
    }
}
