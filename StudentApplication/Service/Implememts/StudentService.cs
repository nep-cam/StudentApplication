using StudentApplication.DbContexts;
using StudentApplication.Dto.Student;
using StudentApplication.Entity;
using StudentApplication.Service.Interfaces;
using System.Security.Cryptography;

namespace StudentApplication.Service.Implememts
{
    public class StudentService :IStudentService
    {
        private readonly ApplicationDbContext _context;
        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public void Create(CreateStudentDto input)
        {
            _context.Students.Add(new Student
            {
                Id = ++_context.StudentID,
                Name = input.Name,
                StudentCode = input.StudentCode,
                DateOfBirth = input.DateOfBirth
            });
        }
        public List<StudentDto> GetAll()
        {

        }
        void Update(UpdateStudentDto input)
        {

        }
        void Delete(int id)
        {

        }
        StudentDto getById(int id)
        {

        }
    }
}
