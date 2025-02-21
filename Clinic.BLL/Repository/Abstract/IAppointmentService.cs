using Clinic.DAL.Entities;

namespace Clinic.BLL.Repository.Abstract
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment> AddAsync(Appointment appointment);
        Task UpdateAsync(Appointment appointment);
        Task DeleteAsync(int Id);
    }
}
