using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.BLL.Repository.Implementation
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public async Task<Schedule> AddAsync(Schedule schedule)
        {
            return await _scheduleRepository.AddAsync(schedule);
        }

        public Task DeleteAsync(int Id)
        {
            return _scheduleRepository.DeleteAsync(Id);
        }

        public async Task<List<Schedule>> GetAllAsync()
        {
            return await _scheduleRepository.GetAllAsync();
        }

        public Task UpdateAsync(Schedule schedule)
        {
            return _scheduleRepository.UpdateAsync(schedule);
        }
    }
}
