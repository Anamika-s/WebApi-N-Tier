using Business_Access_Layer.Models;
using Data_Access_Layer;

using Data_Access_Layer.Repository.Entities;

namespace Business_Access_Layer
{
    public class StudentBal
    {
        private StudentDal _dal;
        public StudentBal() { 
        _dal = new StudentDal();
        }

        public List<Student> GetStudents()
        {
            return _dal.GetStudentsBySP();
        }

        public Student GetStudentById(int id)
        {
            // filter
            // search
            // modify the request in BAL
            return _dal.GetStudentById(id);
        }
        public Student AddStudent(Student student)
        {
            return _dal.AddStudent(student);
        }

    }
}