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

        public Task DeleteAsync(int Id)
        {
            return _appointmentRepository.DeleteAsync(Id);
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _appointmentRepository.GetAllAsync();
        }

        public Task UpdateAsync(Appointment appointment)
        {
            return _appointmentRepository.UpdateAsync(appointment);
        }
        public async Task BookAppointmentAsync(int doctorId, int patientId, DateTime time, Payment payment,int recId)
        {
            var appointment = new Appointment
            {
                DoctorId = doctorId,
                PatientId = patientId,
                Time = time,
                Payment = payment,
                ReceptionistId=recId
            };

             await _appointmentRepository.AddAsync(appointment);
        }
        ////public async Task<bool> BookAppointmentAsync(int doctorId, int patientId, DateTime appointmentTime, int paymentId, int receptionistId)
        ////{
        ////    // Check if the doctor is available
        ////    bool isAvailable = await _appointmentRepository.IsDoctorAvailableAsync(doctorId, appointmentTime);
        ////    if (!isAvailable)
        ////    {
        ////        return false; 
        ////    }

        ////    // Create a new appointment
        ////    var appointment = new Appointment
        ////    {
        ////        DoctorId = doctorId,
        ////        PatientId = patientId,
        ////        Time = appointmentTime,
        ////        FollowUpDate = appointmentTime.AddDays(7), // by def
        ////        PaymentId = paymentId,
        ////        ReceptionistId = receptionistId
        ////    };

        ////    await _appointmentRepository.AddAsync(appointment);

        ////    return true;
        ////}
    }
}
