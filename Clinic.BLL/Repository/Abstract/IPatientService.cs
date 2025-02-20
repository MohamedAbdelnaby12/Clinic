using Clinic.DAL.Entities;

namespace Clinic.BLL.Repository.Abstract
{
    public interface IPatientService
    {
        Task<List<Patient>> GetAllAsync();
        Task<Patient> AddAsync(Patient patient);
        Task<bool> UpdateAsync(Patient patient);
        Task DeleteAsync(Patient patient);
        Task<Patient> GetPatientById(int id);
    }
}
