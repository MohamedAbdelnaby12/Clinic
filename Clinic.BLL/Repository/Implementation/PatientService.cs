using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.BLL.Repository.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public async Task<Patient> AddAsync(Patient patient)
        {
            return await _patientRepository.AddAsync(patient);
        }

        public async Task DeleteAsync(int id)
        {
            await _patientRepository.DeleteAsync(id);
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await _patientRepository.GetAllAsync();
        }

        public async Task<Patient> GetPatientById(int id)
        {
            return await _patientRepository.GetByIdAsync(id);
        }

        public async Task<List<Patient>> GetPatientByName(string name)
        {
            return await _patientRepository.GetPatientsByNameAsync(name);
        }

        public async Task<bool> UpdateAsync(Patient patient)
        {
            var ExistPatient = await _patientRepository.GetByIdAsync(patient.Id);
            if (ExistPatient == null)
                return false;
            ExistPatient.Name = patient.Name;
            ExistPatient.Age = patient.Age;
            ExistPatient.Phone = patient.Phone;
            ExistPatient.Gender = patient.Gender;
            ExistPatient.Email = patient.Email;

            await _patientRepository.UpdateAsync(ExistPatient);
            return true;
            //return _patientRepository.UpdateAsync(patient);
        }
    }
}
