using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public ScheduleService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<Schedule>().GetListAsync();
        }

        public async Task<Schedule> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<Schedule>().GetByIdAsync(id);
        }

        public async Task CreateAsync(Schedule entity)
        {
            await _unitOfWork.GetRepository<Schedule>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(Schedule entity)
        {
            _unitOfWork.GetRepository<Schedule>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<Schedule>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<Schedule>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    
    }
}
