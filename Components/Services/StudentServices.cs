using Component.Model;
using Component.Services;
using Component.Repository;

namespace Component.StudentServices
{
    class StudentServices : IStudentServices {
        private IStudent studentrepo;
        
        public StudentServices(IStudent _studentRepo)
        {
            studentrepo = _studentRepo;
        }

        public async Task<Student> AddAsync(Student student)
        {
            return await studentrepo.AddAsync(student);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await studentrepo.DeleteAsync(id);
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await studentrepo.GetAllAsync();
        }

        public Task<Student?> GetByIdAsync(int id)
        {
            return studentrepo.GetByIdAsync(id);
        }

        public async Task<Student> UpdateAsync(Student student)
        {
            return await studentrepo.UpdateAsync(student);
        }
    }
}