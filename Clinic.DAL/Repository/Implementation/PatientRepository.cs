using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.DAL.Repository.Implementation
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
        }
    }
}
