using Clinic.DAL.Entities;

namespace Clinic.BLL.Repository.Abstract
{
    public interface IDoctorService
    {
        Task<List<Doctor>> GetAllAsync();
        Task<Doctor> AddAsync(Doctor doctor);
        Task<bool> UpdateAsync(Doctor doctor);
        Task DeleteAsync(Doctor doctor);
        Task<Doctor> GetDoctortById(int id);
        Task<Doctor> GetByScheduleIdAsync(int scheduleId);


    }
}
