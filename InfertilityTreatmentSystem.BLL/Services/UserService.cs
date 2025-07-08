using InfertilityTreatmentSystem.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _unitOfWork.Repository<User>().GetListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.Repository<User>().GetByIdAsync(id);
        }

        public async Task CreateAsync(User user)
        {
            await _unitOfWork.Repository<User>().InsertAsync(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _unitOfWork.Repository<User>().Update(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _unitOfWork.Repository<User>().GetByIdAsync(id);
            if (user != null)
            {
                _unitOfWork.Repository<User>().Delete(user);
                await _unitOfWork.SaveChangesAsync();
            }
        }
    }
}
