using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.BLL.Repository.Implementation
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public async Task<Appointment> AddAsync(Appointment appointment)
        {
            return await _appointmentRepository.AddAsync(appointment);
        }

        public Task DeleteAsync(Appointment appointment)
        {
            return _appointmentRepository.DeleteAsync(appointment);
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _appointmentRepository.GetAllAsync();
        }

        public Task UpdateAsync(Appointment appointment)
        {
            return _appointmentRepository.UpdateAsync(appointment);
        }
    }
}
