using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface IPatientRequestService
    {
        Task<IEnumerable<PatientRequest>> GetAllAsync();
        Task<PatientRequest> GetByIdAsync(Guid id);
        Task CreateAsync(PatientRequest entity);
        Task UpdateAsync(PatientRequest entity);
        Task DeleteAsync(Guid id);
    }

}
