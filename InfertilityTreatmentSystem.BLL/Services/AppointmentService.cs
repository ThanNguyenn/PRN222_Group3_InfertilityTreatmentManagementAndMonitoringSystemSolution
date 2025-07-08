using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public AppointmentService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<Appointment>().GetListAsync();
        }

        public async Task<Appointment> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<Appointment>().GetByIdAsync(id);
        }

        public async Task CreateAsync(Appointment entity)
        {
            await _unitOfWork.GetRepository<Appointment>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(Appointment entity)
        {
            _unitOfWork.GetRepository<Appointment>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<Appointment>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<Appointment>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
