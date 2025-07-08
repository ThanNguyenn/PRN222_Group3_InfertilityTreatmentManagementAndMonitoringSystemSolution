using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfertilityTreatmentSystem.BLL.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync();
        Task<Blog> GetByIdAsync(Guid id);
        Task CreateAsync(Blog entity);
        Task UpdateAsync(Blog entity);
        Task DeleteAsync(Guid id);
    }
}
