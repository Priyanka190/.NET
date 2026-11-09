using Component.Model;

namespace Component.Services
{
    public interface IStudentServices
    {
        Task<Student?> GetByIdAsync(int id);

        Task<List<Student>> GetAllAsync();

        Task<Student> AddAsync(Student student);

        Task<Student> UpdateAsync(Student student);

        Task<bool> DeleteAsync(int id);
    }
    
}