using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL.Repository.Implementation
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        private readonly ClinicDbContext _clinicDbContext;

        public PatientRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
            _clinicDbContext = clinicDbContext;
        }

        public async Task<List<Patient>> GetPatientsByNameAsync(string Name)
        {
            return await _clinicDbContext.Patients.Where(p => p.Name.ToLower().Contains(Name.ToLower()))
                                                  .ToListAsync();
        }
    }
}
