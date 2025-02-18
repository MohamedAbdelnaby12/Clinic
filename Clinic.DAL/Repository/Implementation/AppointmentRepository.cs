using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.DAL.Repository.Implementation
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
        }
    }
}
