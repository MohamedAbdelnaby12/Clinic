using Clinic.DAL.Entities;

namespace Clinic.BLL.Repository.Abstract
{
    public interface IScheduleService
    {
        Task<List<Schedule>> GetAllAsync();
        Task<Schedule> AddAsync(Schedule schedule);
        Task<Schedule> GetByIdAsync(int id);

        Task UpdateAsync(Schedule schedule);
        Task DeleteAsync(Schedule schedule);
    }
}
