using Clinic.DAL.Entities;

namespace Clinic.BLL.Repository.Abstract
{
    public interface IReceptionistService
    {
        Task<IEnumerable<Receptionist>> GetAllReceptionistsAsync();
        Task<Receptionist> GetReceptionistByIdAsync(int id);
        Task AddReceptionistAsync(Receptionist receptionist);
        Task UpdateReceptionistAsync(Receptionist receptionist);
        Task DeleteReceptionistAsync(int id);
    }
}