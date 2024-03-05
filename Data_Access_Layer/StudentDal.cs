
using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer
{
    public class StudentDal
    {
        private StudentDbContext _context;
        public StudentDal() { 
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

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }


    }
}