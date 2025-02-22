using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL.Repository.Implementation
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly ClinicDbContext _clinicDbContext;

        public AppointmentRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
            _clinicDbContext = clinicDbContext;
        }
        public async Task<bool> IsDoctorAvailableAsync(int doctorId, DateTime appointmentTime)
        {
            // Check if the doctor has an appointment at the same time or within 30 minutes
            return !await _clinicDbContext.Appointments.AnyAsync(a =>
                a.DoctorId == doctorId &&
                Math.Abs(EF.Functions.DateDiffMinute(a.Time, appointmentTime)) < 30);
        }

        

    }
}
