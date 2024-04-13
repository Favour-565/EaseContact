using SQ20.Net_Wee7_8_Task.Models;

namespace SQ20.Net_Wee7_8_Task.Interface
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skill>> GetAll();

        Task<Skill> GetByIdAsync(Guid id);

        bool Update(Skill skill);

        bool Add(Skill skill);

        bool Save();

    }
}
