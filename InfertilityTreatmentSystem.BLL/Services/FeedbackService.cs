using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public FeedbackService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Feedback>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<Feedback>().GetListAsync();
        }

        public async Task<Feedback> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<Feedback>().GetByIdAsync(id);
        }

        public async Task CreateAsync(Feedback entity)
        {
            await _unitOfWork.GetRepository<Feedback>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(Feedback entity)
        {
            _unitOfWork.GetRepository<Feedback>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<Feedback>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<Feedback>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
