using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAllAsync();
        Task<Appointment> GetByIdAsync(Guid id);
        Task CreateAsync(Appointment entity);
        Task UpdateAsync(Appointment entity);
        Task DeleteAsync(Guid id);
    }
}
