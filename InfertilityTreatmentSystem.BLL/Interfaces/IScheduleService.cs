using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface IScheduleService
    {
        Task<IEnumerable<Schedule>> GetAllAsync();
        Task<Schedule> GetByIdAsync(Guid id);
        Task CreateAsync(Schedule entity);
        Task UpdateAsync(Schedule entity);
        Task DeleteAsync(Guid id);
    }
}
