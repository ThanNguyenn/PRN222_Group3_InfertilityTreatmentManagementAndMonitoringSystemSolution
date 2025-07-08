using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        public BlogService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<Blog>().GetListAsync();
        }

        public async Task<Blog> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<Blog>().GetByIdAsync(id);
        }

        public async Task CreateAsync(Blog entity)
        {
            await _unitOfWork.GetRepository<Blog>().InsertAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(Blog entity)
        {
            _unitOfWork.GetRepository<Blog>().Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _unitOfWork.GetRepository<Blog>().GetByIdAsync(id);
            if (item != null)
            {
                _unitOfWork.GetRepository<Blog>().Delete(item);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
