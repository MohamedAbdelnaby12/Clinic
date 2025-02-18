using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.DAL.Repository.Implementation
{
    public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ClinicDbContext clinicDbContext) : base(clinicDbContext)
        {
        }
    }
}
