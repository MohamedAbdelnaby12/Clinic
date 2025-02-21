using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Abstract;
using Clinic.DAL.Repository.Implementation;

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

        public Task DeleteAsync(int Id)
        {
            return _doctorRepository.DeleteAsync(Id);
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _doctorRepository.GetAllAsync();
        }

        public async Task<Doctor> GetByScheduleIdAsync(int scheduleId)
        {
            return await _doctorRepository.GetAsync(d => d.ScheduleId == scheduleId);
        }

        public async Task<Doctor> GetDoctortById(int id)
        {
            return await _doctorRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Doctor doctor)
        {
            var ExistDoctor = await _doctorRepository.GetByIdAsync(doctor.Id);
            if (ExistDoctor == null)
                return false;
            ExistDoctor.Name = doctor.Name;
            ExistDoctor.Specialization = doctor.Specialization;
            ExistDoctor.Phone = doctor.Phone;
            ExistDoctor.Email = doctor.Email;

            await _doctorRepository.UpdateAsync(ExistDoctor);
            return true;
        }
    }
}
