using SQ20.Net_Wee7_8_Task.Models;

namespace SQ20.Net_Wee7_8_Task.Interface
{
    public interface IExperienceRepository
    {
        Task<IEnumerable<Experience>> GetAll();

        Task<Experience> GetByIdAsync(Guid Id);

        bool Update(Experience project);

        bool Add(Experience project);

        bool Save();
    }
}
