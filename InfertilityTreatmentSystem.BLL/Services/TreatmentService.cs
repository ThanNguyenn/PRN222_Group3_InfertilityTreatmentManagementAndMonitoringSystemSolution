using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class TreatmentServiceService : ITreatmentServiceService
    {
       {
    private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public TreatmentServiceService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TreatmentService>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<TreatmentService>().GetListAsync();
        }

        public async Task<TreatmentService> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<TreatmentService>().GetByIdAsync(id);
        }

        public async Task CreateAsync(TreatmentService entity)
        {
            await _unitOfWork.GetRepository<TreatmentService>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(TreatmentService entity)
        {
            _unitOfWork.GetRepository<TreatmentService>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<TreatmentService>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<TreatmentService>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
