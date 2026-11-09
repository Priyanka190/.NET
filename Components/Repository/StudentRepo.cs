using Component.DbConnection;
using Component.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Component.Repository
{
    public class StudentRepository : IStudent
    {
        private ApplicationDbContext dbcontext;

        public StudentRepository(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public async Task<Student> AddAsync(Student student)
        {
                await dbcontext.Students.AddAsync(student);
                await dbcontext.SaveChangesAsync();

                return student;
            }

        public async Task<bool> DeleteAsync(int id)
        {
            var student = await dbcontext.Students.FindAsync(id);
            if(student!=null) {
                dbcontext.Students.Remove(student);
                dbcontext.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await dbcontext.Students.ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
           return await dbcontext.Students.FindAsync(id);
        }

        public async Task<Student> UpdateAsync(Student student)
        {
            dbcontext.Students.Update(student);
            await dbcontext.SaveChangesAsync();
            return student;

        }
    }
}