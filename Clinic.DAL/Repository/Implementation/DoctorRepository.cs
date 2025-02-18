using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.DAL.Repository.Implementation
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
        }
    }
}
