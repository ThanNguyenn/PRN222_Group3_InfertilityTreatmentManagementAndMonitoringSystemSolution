using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface ITreatmentServiceService
    {
        Task<IEnumerable<TreatmentService>> GetAllAsync();
        Task<TreatmentService> GetByIdAsync(Guid id);
        Task CreateAsync(TreatmentService entity);
        Task UpdateAsync(TreatmentService entity);
        Task DeleteAsync(Guid id);
    }
}
