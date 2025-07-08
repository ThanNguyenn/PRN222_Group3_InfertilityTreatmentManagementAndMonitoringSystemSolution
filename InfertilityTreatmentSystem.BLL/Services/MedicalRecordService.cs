using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public MedicalRecordService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<MedicalRecord>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<MedicalRecord>().GetListAsync();
        }

        public async Task<MedicalRecord> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<MedicalRecord>().GetByIdAsync(id);
        }

        public async Task CreateAsync(MedicalRecord entity)
        {
            await _unitOfWork.GetRepository<MedicalRecord>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(MedicalRecord entity)
        {
            _unitOfWork.GetRepository<MedicalRecord>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<MedicalRecord>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<MedicalRecord>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
