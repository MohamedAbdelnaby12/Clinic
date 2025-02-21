using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.BLL.Services
{
    public class ReceptionistService : IReceptionistService
    {
        private readonly IReceptionistRepository _repository;

        public ReceptionistService(IReceptionistRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Receptionist>> GetAllReceptionistsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Receptionist> GetReceptionistByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddReceptionistAsync(Receptionist receptionist)
        {
            await _repository.AddAsync(receptionist);
        }

        public async Task UpdateReceptionistAsync(Receptionist receptionist)
        {
            await _repository.UpdateAsync(receptionist);
        }

        public async Task DeleteReceptionistAsync(int id)
        {
            var receptionist = await _repository.GetByIdAsync(id);
            if (receptionist != null)
            {
                await _repository.DeleteAsync(id);
            }
        }
        public Task<bool> AddReceptionistAndUserAsync(string name, string phone, string email, string password)
        {
            return _repository.AddReceptionistAndUserAsync( name,  phone,  email,  password);
        }
    }
}