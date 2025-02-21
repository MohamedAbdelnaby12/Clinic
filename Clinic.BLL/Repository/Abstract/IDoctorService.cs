using Clinic.DAL.Entities;

namespace Clinic.BLL.Repository.Abstract
{
    public interface IDoctorService
    {
        Task<List<Doctor>> GetAllAsync();
        Task<Doctor> AddAsync(Doctor doctor);
        Task UpdateAsync(Doctor doctor);
        Task DeleteAsync(int Id);
    }
}
