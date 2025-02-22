using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepository;

namespace Clinic.DAL.Repository.Abstract
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {
        public Task<bool> IsDoctorAvailableAsync(int doctorId, DateTime appointmentTime);
    }
}
