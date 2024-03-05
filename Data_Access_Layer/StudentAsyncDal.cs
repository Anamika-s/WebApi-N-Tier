
using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer
{
    public class StudentAsyncDal
    {
        private StudentDbContext _context;
        public StudentAsyncDal() { 
        _context = new StudentDbContext();
        }

        public List<Student> GetStudentsBySP()
        {
            //return _context.Students.FromSql($"exec dbo.GetStudents").ToList();
            //_context.Database.ExecuteSql($"GetStudents");
            var list  =_context?.Students?.FromSqlInterpolated($"GetStudents").ToList();
            //var list = _context.Students.FromSqlInterpolated($"GetStudents").ToList();
            List<Student> lists = new List<Student>();
            foreach (var obj in list)
            {
                var student = new Student()
                { Id = obj.Id, Name = obj.Name };
                lists.Add(student);

            }
            return lists;

        }

        public async Task<List<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
           await _context.SaveChangesAsync();
            return student;
        }


    }
}