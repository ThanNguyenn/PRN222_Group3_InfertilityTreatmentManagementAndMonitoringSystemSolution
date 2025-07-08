using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class PatientRequestService : IPatientRequestService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public PatientRequestService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PatientRequest>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<PatientRequest>().GetListAsync();
        }

        public async Task<PatientRequest> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<PatientRequest>().GetByIdAsync(id);
        }

        public async Task CreateAsync(PatientRequest entity)
        {
            await _unitOfWork.GetRepository<PatientRequest>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(PatientRequest entity)
        {
            _unitOfWork.GetRepository<PatientRequest>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<PatientRequest>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<PatientRequest>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}