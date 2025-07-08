using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface IMedicalRecordService
    {
        Task<IEnumerable<MedicalRecord>> GetAllAsync();
        Task<MedicalRecord> GetByIdAsync(Guid id);
        Task CreateAsync(MedicalRecord entity);
        Task UpdateAsync(MedicalRecord entity);
        Task DeleteAsync(Guid id);
    }
}
