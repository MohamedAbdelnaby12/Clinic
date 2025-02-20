using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.BLL.Repository.Implementation
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public async Task<Doctor> AddAsync(Doctor doctor)
        {
            return await _doctorRepository.AddAsync(doctor);
        }

        public Task DeleteAsync(Doctor doctor)
        {
            return _doctorRepository.DeleteAsync(doctor);
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _doctorRepository.GetAllAsync();
        }

        public Task UpdateAsync(Doctor doctor)
        {
            return _doctorRepository.UpdateAsync(doctor);
        }
    }
}
