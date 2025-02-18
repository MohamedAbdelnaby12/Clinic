using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.DAL.Repository.Implementation
{
    public class ReceptionistRepository : GenericRepository<Receptionist>, IReceptionistRepository
    {
        public ReceptionistRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
        }
    }
}
