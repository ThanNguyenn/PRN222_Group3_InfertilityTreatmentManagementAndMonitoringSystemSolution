using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface IFeedbackService
    {
        Task<IEnumerable<Feedback>> GetAllAsync();
        Task<Feedback> GetByIdAsync(Guid id);
        Task CreateAsync(Feedback entity);
        Task UpdateAsync(Feedback entity);
        Task DeleteAsync(Guid id);
    }
}
